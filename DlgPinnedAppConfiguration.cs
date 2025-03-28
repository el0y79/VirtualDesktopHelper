using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VirtualDesktopHelper
{
    public partial class DlgPinnedAppConfiguration : Form
    {
        public List<PinnedAppConfiguration> PinnedApps
        {
            get
            {
                List<PinnedAppConfiguration> pinnedApps = new List<PinnedAppConfiguration>();
                foreach (PinnedAppConfiguration pinnedApp in lstPinnedApps.Items)
                {
                    pinnedApps.Add(pinnedApp);
                }
                return pinnedApps;
            }
            set
            {
                lstPinnedApps.Items.Clear();
                foreach (PinnedAppConfiguration pinnedApp in value)
                {
                    lstPinnedApps.Items.Add(pinnedApp);
                }
            }
        }

        public DlgPinnedAppConfiguration()
        {
            InitializeComponent();
        }

        private void UpdateDialog()
        {
            btnRemove.Enabled = lstPinnedApps.SelectedItems.Count > 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openExecutable.ShowDialog() == DialogResult.OK)
            {
                string filePath = openExecutable.FileName;
                string fileName = System.IO.Path.GetFileName(filePath);
                // Add the executable to the list
                lstPinnedApps.Items.Add(new PinnedAppConfiguration { AppName = fileName, AppPath = filePath });
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPinnedApps.SelectedItems.Count > 0)
            {
                lstPinnedApps.Items.Remove(lstPinnedApps.SelectedItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lstPinnedApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }
    }
}
