namespace VirtualDesktopHelper
{
    partial class DlgPinnedAppConfiguration
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
            lstPinnedApps = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            openExecutable = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // lstPinnedApps
            // 
            lstPinnedApps.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstPinnedApps.FormattingEnabled = true;
            lstPinnedApps.ItemHeight = 15;
            lstPinnedApps.Location = new System.Drawing.Point(12, 31);
            lstPinnedApps.Name = "lstPinnedApps";
            lstPinnedApps.Size = new System.Drawing.Size(288, 94);
            lstPinnedApps.TabIndex = 0;
            lstPinnedApps.SelectedIndexChanged += lstPinnedApps_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAdd.Location = new System.Drawing.Point(14, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemove.Location = new System.Drawing.Point(95, 131);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(75, 23);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Pinned Apps:";
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.Location = new System.Drawing.Point(225, 131);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // openExecutable
            // 
            openExecutable.DefaultExt = "*.exe";
            openExecutable.FileName = "*.exe";
            openExecutable.Title = "Select executable...";
            // 
            // DlgPinnedAppConfiguration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(316, 165);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstPinnedApps);
            Name = "DlgPinnedAppConfiguration";
            Text = "DlgPinnedAppConfiguration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstPinnedApps;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openExecutable;
    }
}