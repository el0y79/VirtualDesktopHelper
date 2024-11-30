namespace VirtualDesktopHelper
{
    partial class DlgEditHotKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtDesktopName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSwitchToHotKey = new System.Windows.Forms.TextBox();
            btnSwitchToSelectHotKey = new System.Windows.Forms.Button();
            lblInstructionSwitchTo = new System.Windows.Forms.Label();
            chkSwitchToCTRL = new System.Windows.Forms.CheckBox();
            chkSwitchToALT = new System.Windows.Forms.CheckBox();
            chkSwitchToSHFT = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            txtSendToHotKey = new System.Windows.Forms.TextBox();
            btnSendToSelectHotKey = new System.Windows.Forms.Button();
            lblInstructionSendTo = new System.Windows.Forms.Label();
            chkSendToCTRL = new System.Windows.Forms.CheckBox();
            chkSendToALT = new System.Windows.Forms.CheckBox();
            chkSendToSHFT = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnOk.Location = new System.Drawing.Point(290, 297);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.Location = new System.Drawing.Point(371, 297);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Desktop:";
            // 
            // txtDesktopName
            // 
            txtDesktopName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDesktopName.Location = new System.Drawing.Point(71, 6);
            txtDesktopName.Name = "txtDesktopName";
            txtDesktopName.ReadOnly = true;
            txtDesktopName.Size = new System.Drawing.Size(375, 23);
            txtDesktopName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "HotKey:";
            // 
            // txtSwitchToHotKey
            // 
            txtSwitchToHotKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSwitchToHotKey.Location = new System.Drawing.Point(65, 16);
            txtSwitchToHotKey.Name = "txtSwitchToHotKey";
            txtSwitchToHotKey.ReadOnly = true;
            txtSwitchToHotKey.Size = new System.Drawing.Size(272, 23);
            txtSwitchToHotKey.TabIndex = 5;
            // 
            // btnSwitchToSelectHotKey
            // 
            btnSwitchToSelectHotKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSwitchToSelectHotKey.Location = new System.Drawing.Point(353, 15);
            btnSwitchToSelectHotKey.Name = "btnSwitchToSelectHotKey";
            btnSwitchToSelectHotKey.Size = new System.Drawing.Size(75, 23);
            btnSwitchToSelectHotKey.TabIndex = 6;
            btnSwitchToSelectHotKey.Text = "Select";
            btnSwitchToSelectHotKey.UseVisualStyleBackColor = true;
            btnSwitchToSelectHotKey.Click += btnSwitchToSelectHotKey_Click;
            // 
            // lblInstructionSwitchTo
            // 
            lblInstructionSwitchTo.AutoSize = true;
            lblInstructionSwitchTo.Location = new System.Drawing.Point(65, 54);
            lblInstructionSwitchTo.Name = "lblInstructionSwitchTo";
            lblInstructionSwitchTo.Size = new System.Drawing.Size(288, 15);
            lblInstructionSwitchTo.TabIndex = 7;
            lblInstructionSwitchTo.Text = "Please press the hot key for switching to this desktop.";
            lblInstructionSwitchTo.Visible = false;
            // 
            // chkSwitchToCTRL
            // 
            chkSwitchToCTRL.AutoSize = true;
            chkSwitchToCTRL.Location = new System.Drawing.Point(65, 81);
            chkSwitchToCTRL.Name = "chkSwitchToCTRL";
            chkSwitchToCTRL.Size = new System.Drawing.Size(75, 19);
            chkSwitchToCTRL.TabIndex = 8;
            chkSwitchToCTRL.Text = "Use CTRL";
            chkSwitchToCTRL.UseVisualStyleBackColor = true;
            chkSwitchToCTRL.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // chkSwitchToALT
            // 
            chkSwitchToALT.AutoSize = true;
            chkSwitchToALT.Location = new System.Drawing.Point(146, 81);
            chkSwitchToALT.Name = "chkSwitchToALT";
            chkSwitchToALT.Size = new System.Drawing.Size(67, 19);
            chkSwitchToALT.TabIndex = 9;
            chkSwitchToALT.Text = "Use ALT";
            chkSwitchToALT.UseVisualStyleBackColor = true;
            chkSwitchToALT.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // chkSwitchToSHFT
            // 
            chkSwitchToSHFT.AutoSize = true;
            chkSwitchToSHFT.Location = new System.Drawing.Point(227, 81);
            chkSwitchToSHFT.Name = "chkSwitchToSHFT";
            chkSwitchToSHFT.Size = new System.Drawing.Size(78, 19);
            chkSwitchToSHFT.TabIndex = 10;
            chkSwitchToSHFT.Text = "Use SHIFT";
            chkSwitchToSHFT.UseVisualStyleBackColor = true;
            chkSwitchToSHFT.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSwitchToHotKey);
            groupBox1.Controls.Add(btnSwitchToSelectHotKey);
            groupBox1.Controls.Add(lblInstructionSwitchTo);
            groupBox1.Controls.Add(chkSwitchToCTRL);
            groupBox1.Controls.Add(chkSwitchToALT);
            groupBox1.Controls.Add(chkSwitchToSHFT);
            groupBox1.Location = new System.Drawing.Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(434, 112);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "SwitchTo";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSendToHotKey);
            groupBox2.Controls.Add(btnSendToSelectHotKey);
            groupBox2.Controls.Add(lblInstructionSendTo);
            groupBox2.Controls.Add(chkSendToCTRL);
            groupBox2.Controls.Add(chkSendToALT);
            groupBox2.Controls.Add(chkSendToSHFT);
            groupBox2.Location = new System.Drawing.Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(434, 112);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "SendTo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "HotKey:";
            // 
            // txtSendToHotKey
            // 
            txtSendToHotKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSendToHotKey.Location = new System.Drawing.Point(65, 16);
            txtSendToHotKey.Name = "txtSendToHotKey";
            txtSendToHotKey.ReadOnly = true;
            txtSendToHotKey.Size = new System.Drawing.Size(272, 23);
            txtSendToHotKey.TabIndex = 5;
            // 
            // btnSendToSelectHotKey
            // 
            btnSendToSelectHotKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSendToSelectHotKey.Location = new System.Drawing.Point(353, 15);
            btnSendToSelectHotKey.Name = "btnSendToSelectHotKey";
            btnSendToSelectHotKey.Size = new System.Drawing.Size(75, 23);
            btnSendToSelectHotKey.TabIndex = 6;
            btnSendToSelectHotKey.Text = "Select";
            btnSendToSelectHotKey.UseVisualStyleBackColor = true;
            btnSendToSelectHotKey.Click += btnSendToSelectHotKey_Click;
            // 
            // lblInstructionSendTo
            // 
            lblInstructionSendTo.AutoSize = true;
            lblInstructionSendTo.Location = new System.Drawing.Point(65, 54);
            lblInstructionSendTo.Name = "lblInstructionSendTo";
            lblInstructionSendTo.Size = new System.Drawing.Size(315, 15);
            lblInstructionSendTo.TabIndex = 7;
            lblInstructionSendTo.Text = "Please press the hot key for sending windows this desktop.";
            lblInstructionSendTo.Visible = false;
            // 
            // chkSendToCTRL
            // 
            chkSendToCTRL.AutoSize = true;
            chkSendToCTRL.Location = new System.Drawing.Point(65, 81);
            chkSendToCTRL.Name = "chkSendToCTRL";
            chkSendToCTRL.Size = new System.Drawing.Size(75, 19);
            chkSendToCTRL.TabIndex = 8;
            chkSendToCTRL.Text = "Use CTRL";
            chkSendToCTRL.UseVisualStyleBackColor = true;
            chkSendToCTRL.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // chkSendToALT
            // 
            chkSendToALT.AutoSize = true;
            chkSendToALT.Location = new System.Drawing.Point(146, 81);
            chkSendToALT.Name = "chkSendToALT";
            chkSendToALT.Size = new System.Drawing.Size(67, 19);
            chkSendToALT.TabIndex = 9;
            chkSendToALT.Text = "Use ALT";
            chkSendToALT.UseVisualStyleBackColor = true;
            chkSendToALT.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // chkSendToSHFT
            // 
            chkSendToSHFT.AutoSize = true;
            chkSendToSHFT.Location = new System.Drawing.Point(227, 81);
            chkSendToSHFT.Name = "chkSendToSHFT";
            chkSendToSHFT.Size = new System.Drawing.Size(78, 19);
            chkSendToSHFT.TabIndex = 10;
            chkSendToSHFT.Text = "Use SHIFT";
            chkSendToSHFT.UseVisualStyleBackColor = true;
            chkSendToSHFT.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // DlgEditHotKey
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(458, 332);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtDesktopName);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            KeyPreview = true;
            MinimumSize = new System.Drawing.Size(453, 212);
            Name = "DlgEditHotKey";
            Text = "Edit HotKey";
            KeyDown += DlgEditHotKey_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesktopName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSwitchToHotKey;
        private System.Windows.Forms.Button btnSwitchToSelectHotKey;
        private System.Windows.Forms.Label lblInstructionSwitchTo;
        private System.Windows.Forms.CheckBox chkSwitchToCTRL;
        private System.Windows.Forms.CheckBox chkSwitchToALT;
        private System.Windows.Forms.CheckBox chkSwitchToSHFT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSendToHotKey;
        private System.Windows.Forms.Button btnSendToSelectHotKey;
        private System.Windows.Forms.Label lblInstructionSendTo;
        private System.Windows.Forms.CheckBox chkSendToCTRL;
        private System.Windows.Forms.CheckBox chkSendToALT;
        private System.Windows.Forms.CheckBox chkSendToSHFT;
    }
}