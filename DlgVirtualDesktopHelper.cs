using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using VirtualDesktopHelper.Properties;
using WindowsDesktop;

namespace VirtualDesktopHelper
{
    public partial class DlgVirtualDesktopHelper : Form
    {
        private const int NAMED_SWITCHTO_HOTKEY_OFFSET = 0x10000;
        private const int NAMED_SENDTO_HOTKEY_OFFSET = 0x20000;

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        
        [DllImport("user32.dll")]
        public static extern IntPtr GetTopWindow(IntPtr hWnd);

        private NotificationForm notificationForm = null;
        private VirtualDesktop[] desktops;

        private Dictionary<int, VDesktopConfiguration> desktopConfigurations =
            new Dictionary<int, VDesktopConfiguration>();
        private bool firstShow = true;
        private bool terminate = false;
        
        private List<PinnedAppConfiguration> pinnedAppConfigurations = new List<PinnedAppConfiguration>();
        public DlgVirtualDesktopHelper()
        {
            InitializeComponent();
            InitializeVirtualDesktop();
            LoadConfiguration();
            InitializeContextMenu();
            RegisterHotKeys();
        }

        private void RegisterHotKeys()
        {
            for (int i = 0; i < desktops.Length; i++)
            {

                RegisterHotKey(this.Handle, i, 3, (int)Keys.D1 + i);
                if (desktopConfigurations.ContainsKey(i + 1))
                {
                    var cfg = desktopConfigurations[i + 1];
                    if (cfg.SwitchToHotKey.HotKeyKey.HasValue)
                    {
                        RegisterHotKey(this.Handle, i + NAMED_SWITCHTO_HOTKEY_OFFSET, CalculateHotKeyModifier(cfg.SwitchToHotKey),
                            (int)cfg.SwitchToHotKey.HotKeyKey.Value);
                    }
                    if(cfg.SendToHotKey.HotKeyKey.HasValue)
                    {
                        RegisterHotKey(this.Handle, i + NAMED_SENDTO_HOTKEY_OFFSET, CalculateHotKeyModifier(cfg.SendToHotKey),
                            (int)cfg.SendToHotKey.HotKeyKey.Value);
                    }
                }

                RegisterHotKey(this.Handle, SHOW_NOTIFICATION_HOTKEY_ID, 3, (int) Keys.X);
            }
        }

        private const int SHOW_NOTIFICATION_HOTKEY_ID = 0xFFF0;

        private int CalculateHotKeyModifier(HotKeyConfiguration cfg)
        {
            int result = 0;
            if (cfg.HotKeyUsesShift)
            {
                result |= 4;
            }

            if (cfg.HotKeyUsesCtrl)
            {
                result |= 2;
            }

            if (cfg.HotKeyUsesAlt)
            {
                result |= 1;
            }

            return result;
        }

        private void UnregisterHotKeys()
        {
            for (int i = 0; i < desktops.Length; i++)
            {
                UnregisterHotKey(this.Handle, i);
                UnregisterHotKey(this.Handle, i + NAMED_SWITCHTO_HOTKEY_OFFSET);
            }
        }

        private void LoadConfiguration()
        {
            Settings.Default.Upgrade();
            if (Settings.Default.VDesktopConfiguration == null)
            {
                Settings.Default.VDesktopConfiguration = new System.Collections.Specialized.StringCollection();
            }
            foreach (var config in Settings.Default.VDesktopConfiguration)
            {
                var vDesktopConfiguration = config.RestoreFromJson<VDesktopConfiguration>();
                if (vDesktopConfiguration != null) desktopConfigurations[vDesktopConfiguration.Number] = vDesktopConfiguration;
            }

            if (desktopConfigurations.Count < desktops.Length)
            {
                for (int i = 0; i < desktops.Length; i++)
                {
                    if (!desktopConfigurations.ContainsKey(i + 1))
                    {
                        desktopConfigurations.Add(i + 1, new VDesktopConfiguration
                        {
                            Number = i + 1,
                            Name = $"Desktop {i + 1}"
                        });
                    }
                }
            }
            desktopConfigurationGrid.DataSource = new BindingList<VDesktopConfiguration>(new List<VDesktopConfiguration>(desktopConfigurations.Values));

            if (Settings.Default.PinnedAppConfiguration == null)
            {
                Settings.Default.PinnedAppConfiguration = new System.Collections.Specialized.StringCollection();
            }            
            foreach (var config in Settings.Default.PinnedAppConfiguration)
            {
                var pinnedAppConfiguration = config.RestoreFromJson<PinnedAppConfiguration>();
                if (pinnedAppConfiguration != null) pinnedAppConfigurations.Add(pinnedAppConfiguration);
            }
        }

        private void InitializeVirtualDesktop()
        {
            VirtualDesktop.Configure();
            desktops = VirtualDesktop.GetDesktops();
            VirtualDesktop.CurrentChanged -= VirtualDesktop_CurrentChanged;
            VirtualDesktop.CurrentChanged += VirtualDesktop_CurrentChanged;
        }

        private void InitializeContextMenu()
        {
            miSwitchTo.DropDownItems.Clear();
            for (int i = 0; i < desktops.Length; i++)
            {
                string name = $"Desktop {i + 1}";
                if (desktopConfigurations.ContainsKey(i + 1))
                {
                    name = desktopConfigurations[i + 1].Name;
                }

                var tsi = miSwitchTo.DropDownItems.Add(name, null, OnChangeToClicked);
                tsi.Tag = desktops[i];
            }
        }

        private void OnChangeToClicked(object sender, EventArgs e)
        {
            ((VirtualDesktop)((ToolStripItem)sender).Tag).Switch();
        }

        private void VirtualDesktop_CurrentChanged(object sender, VirtualDesktopChangedEventArgs e)
        {
            Console.Out.WriteLine("Desktop changed");
            for (int i = 0; i < desktops.Length; i++)
            {
                if (desktops[i] == e.NewDesktop)
                {
                    Invoke(() => ShowNotification(i));

                    return;
                }
            }
            Console.Out.WriteLine("Desktop not found");
        }

        private void ShowNotification(int i)
        {
            Console.Out.WriteLine($"Desktop {i + 1} is active");
            string name = $"Desktop {i + 1}";
            if (desktopConfigurations.ContainsKey(i + 1))
            {
                name = desktopConfigurations[i + 1].Name;
            }
            else
            {
                desktopConfigurations.Add(i + 1, new VDesktopConfiguration
                {
                    Number = i + 1,
                    Name = name
                });
            }
            if (notificationForm != null)
            {
                Console.Out.WriteLine("Touching existing notification form");
                notificationForm.TouchTimer(name);
                VirtualDesktop.MoveToDesktop(notificationForm.Handle, desktops[i]);
            }
            else
            {
                Console.Out.WriteLine("Creating new notification form");
                notificationForm = new NotificationForm(name, TimeSpan.FromSeconds(3));
                notificationForm.Closing += (s, e2) => notificationForm = null;
                notificationForm.Show();
            }
        }


        private void MiExit_Click(object sender, EventArgs e)
        {
            terminate = true;
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_DISPLAYCHANGE = 0x007e;
            const int WM_HOTKEY = 0x0312;
            // Listen for operating system messages. 
            switch (m.Msg)
            {
                case WM_DISPLAYCHANGE:
                    //Reregister the events
                    InitializeVirtualDesktop();
                    InitializeContextMenu();
                    break;
                case WM_HOTKEY:
                    int param = m.WParam.ToInt32();
                    if (param == SHOW_NOTIFICATION_HOTKEY_ID)
                    {
                        for (int i = 0; i < desktops.Length; i++)
                        {
                            if (VirtualDesktop.Current == desktops[i])
                            {
                                ShowNotification(i);
                                break;
                            }
                        }
                    }
                    if (param < desktops.Length)
                    {
                        desktops[param].Switch();
                    }

                    if (param >= NAMED_SWITCHTO_HOTKEY_OFFSET && param - NAMED_SWITCHTO_HOTKEY_OFFSET < desktops.Length)
                    {
                        desktops[param - NAMED_SWITCHTO_HOTKEY_OFFSET].Switch();
                    }
                    
                    if (param >= NAMED_SENDTO_HOTKEY_OFFSET && param - NAMED_SENDTO_HOTKEY_OFFSET < desktops.Length)
                    {
                        var currentWindow = GetForegroundWindow();
                        if (currentWindow != null)
                        {
                            VirtualDesktop.MoveToDesktop(currentWindow, desktops[param - NAMED_SENDTO_HOTKEY_OFFSET]);
                        }
                    }
                    
                    break;
            }
            base.WndProc(ref m);
        }

        private void DlgVirtualDesktopHelper_Shown(object sender, EventArgs e)
        {
            if (firstShow)
            {
                Hide();
                firstShow = false;
            }
        }

        private void DlgVirtualDesktopHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var configurationsValue in desktopConfigurations.Values)
            {
                Settings.Default.VDesktopConfiguration.Add(configurationsValue.ToJson());
            }
            Settings.Default.Save();
            e.Cancel = !terminate;
            Hide();
            InitializeContextMenu();
            UnregisterHotKeys();
            RegisterHotKeys();
        }

        private void VirtualDesktopNotification_DoubleClick(object sender, EventArgs e)
        {
            Show();
            BringToFront();
            WindowState = FormWindowState.Normal;
        }

        private void EditHotKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = desktopConfigurationGrid.SelectedRows[0];
            var configuration = (VDesktopConfiguration)selected.DataBoundItem;
            var editHotKey = new DlgEditHotKey(configuration);
            if (editHotKey.ShowDialog() == DialogResult.OK)
            {
                desktopConfigurationGrid.Refresh();
            }
        }

        private void DeleteHotKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = desktopConfigurationGrid.SelectedRows[0];
            var configuration = (VDesktopConfiguration)selected.DataBoundItem;
            configuration.SwitchToHotKey.HotKeyKey = null;
            desktopConfigurationGrid.Refresh();
        }

        private void DesktopConfigurationGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = desktopConfigurationGrid.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    desktopConfigurationGrid.ClearSelection();
                    desktopConfigurationGrid.Rows[hti.RowIndex].Selected = true;
                    desktopConfigurationGrid.CurrentCell = desktopConfigurationGrid.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                }

            }
        }

        private void DesktopConfigurationGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                EditHotKeyToolStripMenuItem_Click(null, null);
            }
        }

        private void pinnedAppTimer_Tick(object sender, EventArgs e)
        {
            foreach (var pinnedAppConfiguration in pinnedAppConfigurations)
            {
                Process[] processes = Process.GetProcesses();
                foreach (var process in processes)
                {
                    if (process.MainModule?.FileName == pinnedAppConfiguration.AppPath)
                    {
                        //determine the app id
                        string appId;
                        if (VirtualDesktop.TryGetAppUserModelId(process.MainWindowHandle, out appId))
                        {
                            VirtualDesktop.PinApplication(appId);
                        }
                        else
                        {
                            VirtualDesktop.PinWindow(process.MainWindowHandle);
                        }
                    }                    
                }
            }
        }
    }
}