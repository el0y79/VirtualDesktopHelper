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
            txtHotKey = new System.Windows.Forms.TextBox();
            btnSelectHotKey = new System.Windows.Forms.Button();
            lblInstruction = new System.Windows.Forms.Label();
            chkCTRL = new System.Windows.Forms.CheckBox();
            chkALT = new System.Windows.Forms.CheckBox();
            chkSHFT = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnOk.Location = new System.Drawing.Point(269, 138);
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
            btnCancel.Location = new System.Drawing.Point(350, 138);
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
            txtDesktopName.Size = new System.Drawing.Size(354, 23);
            txtDesktopName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "HotKey:";
            // 
            // txtHotKey
            // 
            txtHotKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtHotKey.Location = new System.Drawing.Point(71, 42);
            txtHotKey.Name = "txtHotKey";
            txtHotKey.ReadOnly = true;
            txtHotKey.Size = new System.Drawing.Size(273, 23);
            txtHotKey.TabIndex = 5;
            // 
            // btnSelectHotKey
            // 
            btnSelectHotKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelectHotKey.Location = new System.Drawing.Point(350, 41);
            btnSelectHotKey.Name = "btnSelectHotKey";
            btnSelectHotKey.Size = new System.Drawing.Size(75, 23);
            btnSelectHotKey.TabIndex = 6;
            btnSelectHotKey.Text = "Select";
            btnSelectHotKey.UseVisualStyleBackColor = true;
            btnSelectHotKey.Click += btnSelectHotKey_Click;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new System.Drawing.Point(71, 80);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new System.Drawing.Size(310, 15);
            lblInstruction.TabIndex = 7;
            lblInstruction.Text = "Please press the key to be used as hotkey for this desktop.";
            lblInstruction.Visible = false;
            // 
            // chkCTRL
            // 
            chkCTRL.AutoSize = true;
            chkCTRL.Location = new System.Drawing.Point(71, 107);
            chkCTRL.Name = "chkCTRL";
            chkCTRL.Size = new System.Drawing.Size(75, 19);
            chkCTRL.TabIndex = 8;
            chkCTRL.Text = "Use CTRL";
            chkCTRL.UseVisualStyleBackColor = true;
            chkCTRL.CheckedChanged += chkCTRL_CheckedChanged;
            // 
            // chkALT
            // 
            chkALT.AutoSize = true;
            chkALT.Location = new System.Drawing.Point(152, 107);
            chkALT.Name = "chkALT";
            chkALT.Size = new System.Drawing.Size(67, 19);
            chkALT.TabIndex = 9;
            chkALT.Text = "Use ALT";
            chkALT.UseVisualStyleBackColor = true;
            chkALT.CheckedChanged += chkALT_CheckedChanged;
            // 
            // chkSHFT
            // 
            chkSHFT.AutoSize = true;
            chkSHFT.Location = new System.Drawing.Point(233, 107);
            chkSHFT.Name = "chkSHFT";
            chkSHFT.Size = new System.Drawing.Size(78, 19);
            chkSHFT.TabIndex = 10;
            chkSHFT.Text = "Use SHIFT";
            chkSHFT.UseVisualStyleBackColor = true;
            chkSHFT.CheckedChanged += chkSHFT_CheckedChanged;
            // 
            // DlgEditHotKey
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(437, 173);
            Controls.Add(chkSHFT);
            Controls.Add(chkALT);
            Controls.Add(chkCTRL);
            Controls.Add(lblInstruction);
            Controls.Add(btnSelectHotKey);
            Controls.Add(txtHotKey);
            Controls.Add(label2);
            Controls.Add(txtDesktopName);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            KeyPreview = true;
            MinimumSize = new System.Drawing.Size(453, 212);
            Name = "DlgEditHotKey";
            Text = "Edit HotKey";
            KeyDown += DlgEditHotKey_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesktopName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHotKey;
        private System.Windows.Forms.Button btnSelectHotKey;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.CheckBox chkCTRL;
        private System.Windows.Forms.CheckBox chkALT;
        private System.Windows.Forms.CheckBox chkSHFT;
    }
}