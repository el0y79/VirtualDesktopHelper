using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using VirtualDesktopHelper.Properties;
using WindowsDesktop;

namespace VirtualDesktopHelper
{
    public partial class DlgVirtualDesktopHelper : Form
    {
        private NotificationForm notificationForm = null;
        private VirtualDesktop[] desktops;

        private Dictionary<int, VDesktopConfiguration> desktopConfigurations =
            new Dictionary<int, VDesktopConfiguration>();
        private bool firstShow = true;
        public DlgVirtualDesktopHelper()
        {
            InitializeComponent();
            InitializeVirtualDesktop();
            LoadConfiguration();
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
                var parts = config.Split('=');
                VDesktopConfiguration vDesktopConfiguration = new VDesktopConfiguration
                {
                    Number = int.Parse(parts[0]),
                    Name = $"Desktop {parts[0]}"
                };
                if (parts.Length > 1)
                {
                    vDesktopConfiguration.Name = parts[1];
                }

                desktopConfigurations[vDesktopConfiguration.Number] = vDesktopConfiguration;
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
            dataGridView1.DataSource = new BindingList<VDesktopConfiguration>(new List<VDesktopConfiguration>(desktopConfigurations.Values));
        }

        private void InitializeVirtualDesktop()
        {
            VirtualDesktop.Configure();
            desktops = VirtualDesktop.GetDesktops();
            VirtualDesktop.CurrentChanged -= VirtualDesktop_CurrentChanged;
            VirtualDesktop.CurrentChanged += VirtualDesktop_CurrentChanged;
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


        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        protected override void WndProc(ref Message m)
        {
            const int WM_DISPLAYCHANGE = 0x007e;
            // Listen for operating system messages. 
            switch (m.Msg)
            {
                case WM_DISPLAYCHANGE:
                    //Reregister the events
                    InitializeVirtualDesktop();
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
                Settings.Default.VDesktopConfiguration.Add($"{configurationsValue.Number}={configurationsValue.Name}");
            }
            Settings.Default.Save();
            e.Cancel = true;
            Hide();
        }

        private void VirtualDesktopNotification_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }
    }
}