namespace VirtualDesktopHelper
{
    partial class DlgVirtualDesktopHelper
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgVirtualDesktopHelper));
            VirtualDesktopNotification = new System.Windows.Forms.NotifyIcon(components);
            ctxMenu = new System.Windows.Forms.ContextMenuStrip(components);
            miExit = new System.Windows.Forms.ToolStripMenuItem();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vDesktopConfigurationBindingSource = new System.Windows.Forms.BindingSource(components);
            ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vDesktopConfigurationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // VirtualDesktopNotification
            // 
            VirtualDesktopNotification.ContextMenuStrip = ctxMenu;
            VirtualDesktopNotification.Icon = (System.Drawing.Icon)resources.GetObject("VirtualDesktopNotification.Icon");
            VirtualDesktopNotification.Text = "VirtualDesktopHelper";
            VirtualDesktopNotification.Visible = true;
            VirtualDesktopNotification.DoubleClick += VirtualDesktopNotification_DoubleClick;
            // 
            // ctxMenu
            // 
            ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miExit });
            ctxMenu.Name = "contextMenuStrip1";
            ctxMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new System.Drawing.Size(180, 22);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { numberDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vDesktopConfigurationBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(697, 461);
            dataGridView1.TabIndex = 1;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // vDesktopConfigurationBindingSource
            // 
            vDesktopConfigurationBindingSource.DataSource = typeof(VDesktopConfiguration);
            // 
            // DlgVirtualDesktopHelper
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(697, 461);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "DlgVirtualDesktopHelper";
            ShowInTaskbar = false;
            Text = "VirtualDesktopHelper";
            FormClosing += DlgVirtualDesktopHelper_FormClosing;
            Shown += DlgVirtualDesktopHelper_Shown;
            ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vDesktopConfigurationBindingSource).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem miExit;

        private System.Windows.Forms.NotifyIcon VirtualDesktopNotification;

#endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vDesktopConfigurationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}