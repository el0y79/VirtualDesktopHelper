using System;
using System.Drawing;
using System.Windows.Forms;

namespace VirtualDesktopHelper;

public partial class NotificationForm : Form
{
    private readonly TimeSpan closeAfter;

    public NotificationForm(string name, TimeSpan closeAfter)
    {
        this.closeAfter = closeAfter;
        InitializeComponent();
        UpdateNumber(name);
    }

    private void UpdateNumber(string name)
    {
        lblDesktopNumber.Text = name;
        this.Size = lblDesktopNumber.Size + new Size(20, 30);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        Console.Out.WriteLine("Closing notification form");
        Close();
    }

    public void TouchTimer(string name)
    {
        UpdateNumber(name);
        timer1.Stop();
        timer1.Start();
    }

    private void NotificationForm_Shown(object sender, EventArgs e)
    {
        Console.Out.WriteLine("Notification form shown");
        timer1.Interval = (int)closeAfter.TotalMilliseconds;
        timer1.Start();
    }
}