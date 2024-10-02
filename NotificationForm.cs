using System;
using System.Windows.Forms;

namespace VirtualDesktopHelper;

public partial class NotificationForm : Form
{
    private readonly TimeSpan closeAfter;

    public NotificationForm(int number, TimeSpan closeAfter)
    {
        this.closeAfter = closeAfter;
        InitializeComponent();
        UpdateNumber(number);
    }

    private void UpdateNumber(int number)
    {
        lblDesktopNumber.Text = number.ToString();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        Console.Out.WriteLine("Closing notification form");
        Close();
    }

    public void TouchTimer(int number)
    {
        UpdateNumber(number);
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