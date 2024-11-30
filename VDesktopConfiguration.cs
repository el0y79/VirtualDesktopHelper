using System.Windows.Forms;

namespace VirtualDesktopHelper;

public class HotKeyConfiguration
{
    public bool HotKeyUsesShift { get; set; }
    public bool HotKeyUsesCtrl { get; set; }
    public bool HotKeyUsesAlt { get; set; }
    public Keys? HotKeyKey { get; set; } = null;

    public string HotKey
    {
        get
        {
            if (HotKeyKey == null)
            {
                return "none";
            }

            var result = HotKeyKey.Value.ToString();
            if (HotKeyUsesShift)
            {
                result = "Shift+" + result;
            }

            if (HotKeyUsesAlt)
            {
                result = "Alt+" + result;
            }
            
            if(HotKeyUsesCtrl)
            {
                result = "Ctrl+" + result;
            }

            return result;
        }
    }
    
    public HotKeyConfiguration Clone()
    {
        return new HotKeyConfiguration()
        {
            HotKeyUsesShift = HotKeyUsesShift,
            HotKeyUsesCtrl = HotKeyUsesCtrl,
            HotKeyUsesAlt = HotKeyUsesAlt,
            HotKeyKey = HotKeyKey
        };
    }

    public override string ToString()
    {
        return HotKey;
    }
}

public class VDesktopConfiguration
{
    public int Number { get; set; }
    public string Name { get; set; }

    public HotKeyConfiguration SwitchToHotKey { get; set; } = new HotKeyConfiguration();
    public HotKeyConfiguration SendToHotKey { get; set; } = new HotKeyConfiguration();

    public VDesktopConfiguration Clone()
    {
        return new VDesktopConfiguration()
        {
            Number = Number,
            Name = Name,
            SwitchToHotKey = SwitchToHotKey.Clone(),
            SendToHotKey = SendToHotKey.Clone()
        };
    }
}