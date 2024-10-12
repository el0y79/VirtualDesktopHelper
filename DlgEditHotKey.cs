using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.Casting;

namespace VirtualDesktopHelper
{
    public partial class DlgEditHotKey : Form
    {
        private readonly VDesktopConfiguration configuration;
        private VDesktopConfiguration workingCopy;
        private bool selectionInProgress = false;

        public DlgEditHotKey(VDesktopConfiguration configuration)
        {
            this.configuration = configuration;
            this.workingCopy = configuration.Clone();

            InitializeComponent();
            txtDesktopName.Text = configuration.Name;

            chkSHFT.Checked = configuration.HotKeyUsesShift;
            chkCTRL.Checked = configuration.HotKeyUsesCtrl;
            chkALT.Checked = configuration.HotKeyUsesAlt;
            txtHotKey.Text = configuration.HotKey;
        }

        private void UpdateDialog()
        {
            workingCopy.HotKeyUsesCtrl = chkCTRL.Checked;
            workingCopy.HotKeyUsesShift = chkSHFT.Checked;
            workingCopy.HotKeyUsesAlt = chkALT.Checked;
            txtHotKey.Text = workingCopy.HotKey;
        }

        public DlgEditHotKey() : this(new VDesktopConfiguration())
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            configuration.HotKeyUsesCtrl = workingCopy.HotKeyUsesCtrl;
            configuration.HotKeyUsesShift = workingCopy.HotKeyUsesShift;
            configuration.HotKeyUsesAlt = workingCopy.HotKeyUsesAlt;
            configuration.HotKeyKey = workingCopy.HotKeyKey;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelectHotKey_Click(object sender, EventArgs e)
        {
            selectionInProgress = true;
            lblInstruction.Visible = true;
        }

        private void DlgEditHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectionInProgress)
            {
                workingCopy.HotKeyKey = e.KeyCode;
                UpdateDialog();
                selectionInProgress = false;
                lblInstruction.Visible = false;
            }
        }

        private void chkCTRL_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void chkALT_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }

        private void chkSHFT_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }
    }
}
