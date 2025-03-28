namespace VirtualDesktopHelper;

public class PinnedAppConfiguration
{
    public string AppName { get; set; }
    public string AppPath { get; set; }

    public override string ToString()
    {
        return $"{AppName} ({AppPath})";
    }
}