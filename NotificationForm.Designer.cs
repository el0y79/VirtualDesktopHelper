using System.ComponentModel;

namespace VirtualDesktopHelper;

partial class NotificationForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        components = new Container();
        groupBox1 = new System.Windows.Forms.GroupBox();
        lblDesktopNumber = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lblDesktopNumber);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        groupBox1.Location = new System.Drawing.Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(366, 119);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "VDesktop";
        // 
        // lblDesktopNumber
        // 
        lblDesktopNumber.AutoSize = true;
        lblDesktopNumber.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDesktopNumber.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblDesktopNumber.Location = new System.Drawing.Point(3, 19);
        lblDesktopNumber.Name = "lblDesktopNumber";
        lblDesktopNumber.Size = new System.Drawing.Size(72, 86);
        lblDesktopNumber.TabIndex = 0;
        lblDesktopNumber.Text = "1";
        lblDesktopNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // NotificationForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(366, 119);
        ControlBox = false;
        Controls.Add(groupBox1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Name = "NotificationForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        Text = "NotificationForm";
        TopMost = true;
        Shown += NotificationForm_Shown;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblDesktopNumber;
    private System.Windows.Forms.Timer timer1;
}