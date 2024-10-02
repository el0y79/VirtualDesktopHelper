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
            testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ctxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // VirtualDesktopNotification
            // 
            VirtualDesktopNotification.ContextMenuStrip = ctxMenu;
            VirtualDesktopNotification.Icon = (System.Drawing.Icon)resources.GetObject("VirtualDesktopNotification.Icon");
            VirtualDesktopNotification.Text = "VirtualDesktopHelper";
            VirtualDesktopNotification.Visible = true;
            // 
            // ctxMenu
            // 
            ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miExit, testToolStripMenuItem });
            ctxMenu.Name = "contextMenuStrip1";
            ctxMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new System.Drawing.Size(180, 22);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            testToolStripMenuItem.Text = "Test";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // DlgVirtualDesktopHelper
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(342, 48);
            ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DlgVirtualDesktopHelper";
            ShowInTaskbar = false;
            Text = "VirtualDesktopHelper";
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ctxMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem miExit;

        private System.Windows.Forms.NotifyIcon VirtualDesktopNotification;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}