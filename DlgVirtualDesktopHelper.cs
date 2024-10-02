using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop;

namespace VirtualDesktopHelper
{
    public partial class DlgVirtualDesktopHelper : Form
    {
        private NotificationForm notificationForm = null;
        private VirtualDesktop[] desktops;
        public DlgVirtualDesktopHelper()
        {
            InitializeComponent();
            InitializeVirtualDesktop();
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
                    Invoke(()=>ShowNotification(i));

                    return;
                }
            }
            Console.Out.WriteLine("Desktop not found");
        }

        private void ShowNotification(int i)
        {
            Console.Out.WriteLine($"Desktop {i + 1} is active");
            if (notificationForm != null)
            {
                Console.Out.WriteLine("Touching existing notification form");
                notificationForm.TouchTimer(i + 1);
                VirtualDesktop.MoveToDesktop(notificationForm.Handle, desktops[i]);                
            }
            else
            {
                Console.Out.WriteLine("Creating new notification form");
                notificationForm = new NotificationForm(i + 1, TimeSpan.FromSeconds(3));
                notificationForm.Closing += (s, e2) => notificationForm = null;
                notificationForm.Show();
            }
        }


        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNotification(0);
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
    }
}