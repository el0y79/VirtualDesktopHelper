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
            miSwitchTo = new System.Windows.Forms.ToolStripMenuItem();
            miExit = new System.Windows.Forms.ToolStripMenuItem();
            desktopConfigurationGrid = new System.Windows.Forms.DataGridView();
            numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HotKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tblCtxMenu = new System.Windows.Forms.ContextMenuStrip(components);
            editHotKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteHotKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vDesktopConfigurationBindingSource = new System.Windows.Forms.BindingSource(components);
            ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)desktopConfigurationGrid).BeginInit();
            tblCtxMenu.SuspendLayout();
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
            ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miSwitchTo, miExit });
            ctxMenu.Name = "contextMenuStrip1";
            ctxMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // miSwitchTo
            // 
            miSwitchTo.Name = "miSwitchTo";
            miSwitchTo.Size = new System.Drawing.Size(124, 22);
            miSwitchTo.Text = "Switch To";
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new System.Drawing.Size(124, 22);
            miExit.Text = "Exit";
            miExit.Click += MiExit_Click;
            // 
            // desktopConfigurationGrid
            // 
            desktopConfigurationGrid.AllowUserToAddRows = false;
            desktopConfigurationGrid.AllowUserToDeleteRows = false;
            desktopConfigurationGrid.AllowUserToResizeRows = false;
            desktopConfigurationGrid.AutoGenerateColumns = false;
            desktopConfigurationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            desktopConfigurationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { numberDataGridViewTextBoxColumn, HotKey, nameDataGridViewTextBoxColumn });
            desktopConfigurationGrid.ContextMenuStrip = tblCtxMenu;
            desktopConfigurationGrid.DataSource = vDesktopConfigurationBindingSource;
            desktopConfigurationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            desktopConfigurationGrid.Location = new System.Drawing.Point(0, 0);
            desktopConfigurationGrid.MultiSelect = false;
            desktopConfigurationGrid.Name = "desktopConfigurationGrid";
            desktopConfigurationGrid.RowHeadersVisible = false;
            desktopConfigurationGrid.RowTemplate.Height = 25;
            desktopConfigurationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            desktopConfigurationGrid.Size = new System.Drawing.Size(697, 461);
            desktopConfigurationGrid.TabIndex = 1;
            desktopConfigurationGrid.MouseDown += DesktopConfigurationGrid_MouseDown;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HotKey
            // 
            HotKey.DataPropertyName = "HotKey";
            HotKey.HeaderText = "HotKey";
            HotKey.Name = "HotKey";
            HotKey.ReadOnly = true;
            HotKey.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // tblCtxMenu
            // 
            tblCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { editHotKeyToolStripMenuItem, deleteHotKeyToolStripMenuItem });
            tblCtxMenu.Name = "tblCtxMenu";
            tblCtxMenu.Size = new System.Drawing.Size(150, 48);
            // 
            // editHotKeyToolStripMenuItem
            // 
            editHotKeyToolStripMenuItem.Name = "editHotKeyToolStripMenuItem";
            editHotKeyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            editHotKeyToolStripMenuItem.Text = "Edit HotKey...";
            editHotKeyToolStripMenuItem.Click += EditHotKeyToolStripMenuItem_Click;
            // 
            // deleteHotKeyToolStripMenuItem
            // 
            deleteHotKeyToolStripMenuItem.Name = "deleteHotKeyToolStripMenuItem";
            deleteHotKeyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            deleteHotKeyToolStripMenuItem.Text = "Delete HotKey";
            deleteHotKeyToolStripMenuItem.Click += DeleteHotKeyToolStripMenuItem_Click;
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
            Controls.Add(desktopConfigurationGrid);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "DlgVirtualDesktopHelper";
            ShowInTaskbar = false;
            Text = "VirtualDesktopHelper";
            FormClosing += DlgVirtualDesktopHelper_FormClosing;
            Shown += DlgVirtualDesktopHelper_Shown;
            ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)desktopConfigurationGrid).EndInit();
            tblCtxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vDesktopConfigurationBindingSource).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem miExit;

        private System.Windows.Forms.NotifyIcon VirtualDesktopNotification;

#endregion
        private System.Windows.Forms.DataGridView desktopConfigurationGrid;
        private System.Windows.Forms.BindingSource vDesktopConfigurationBindingSource;
        private System.Windows.Forms.ToolStripMenuItem miSwitchTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip tblCtxMenu;
        private System.Windows.Forms.ToolStripMenuItem editHotKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteHotKeyToolStripMenuItem;
    }
}