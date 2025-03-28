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
        private bool switchToSelectionInProgress = false;
        private bool sendToSelectionInProgress = false;

        public DlgEditHotKey(VDesktopConfiguration configuration)
        {
            this.configuration = configuration;
            this.workingCopy = configuration.Clone();

            InitializeComponent();
            txtDesktopName.Text = configuration.Name;

            chkSwitchToSHFT.Checked = configuration.SwitchToHotKey.HotKeyUsesShift;
            chkSwitchToCTRL.Checked = configuration.SwitchToHotKey.HotKeyUsesCtrl;
            chkSwitchToALT.Checked = configuration.SwitchToHotKey.HotKeyUsesAlt;
            txtSwitchToHotKey.Text = configuration.SwitchToHotKey.HotKey;
            
            chkSendToCTRL.Checked = configuration.SwitchToHotKey.HotKeyUsesCtrl;
            chkSendToALT.Checked = configuration.SwitchToHotKey.HotKeyUsesAlt;
            chkSendToSHFT.Checked = configuration.SwitchToHotKey.HotKeyUsesShift;
            txtSendToHotKey.Text = configuration.SendToHotKey.HotKey;
        }

        private void UpdateDialog()
        {
            workingCopy.SwitchToHotKey.HotKeyUsesCtrl = chkSwitchToCTRL.Checked;
            workingCopy.SwitchToHotKey.HotKeyUsesShift = chkSwitchToSHFT.Checked;
            workingCopy.SwitchToHotKey.HotKeyUsesAlt = chkSwitchToALT.Checked;
            txtSwitchToHotKey.Text = workingCopy.SwitchToHotKey.HotKey;
            
            workingCopy.SendToHotKey.HotKeyUsesCtrl = chkSendToCTRL.Checked;
            workingCopy.SendToHotKey.HotKeyUsesShift = chkSendToSHFT.Checked;
            workingCopy.SendToHotKey.HotKeyUsesAlt = chkSendToALT.Checked;
            txtSendToHotKey.Text = workingCopy.SendToHotKey.HotKey;
            
            btnOk.Enabled = !string.IsNullOrEmpty(txtDesktopName.Text);
        }

        public DlgEditHotKey() : this(new VDesktopConfiguration())
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            configuration.SwitchToHotKey= workingCopy.SwitchToHotKey;
            configuration.SendToHotKey = workingCopy.SendToHotKey;
            configuration.Name = txtDesktopName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSwitchToSelectHotKey_Click(object sender, EventArgs e)
        {
            switchToSelectionInProgress = true;
            lblInstructionSwitchTo.Visible = true;
        }

        private void btnSendToSelectHotKey_Click(object sender, EventArgs e)
        {
            sendToSelectionInProgress = true;
            lblInstructionSendTo.Visible = true;
        }

        private void DlgEditHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (switchToSelectionInProgress)
            {
                workingCopy.SwitchToHotKey.HotKeyKey = e.KeyCode;
                UpdateDialog();
                switchToSelectionInProgress = false;
                lblInstructionSwitchTo.Visible = false;
            }
            else if (sendToSelectionInProgress)
            {
                workingCopy.SendToHotKey.HotKeyKey = e.KeyCode;
                UpdateDialog();
                sendToSelectionInProgress = false;
                lblInstructionSendTo.Visible = false;
            }
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDialog();
        }
    }
}
