using System.Windows.Forms;

namespace VirtualDesktopHelper;

public class VDesktopConfiguration
{
    public int Number { get; set; }
    public string Name { get; set; }
    
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

    public VDesktopConfiguration Clone()
    {
        return new VDesktopConfiguration()
        {
            Number = Number,
            Name = Name,
            HotKeyUsesShift = HotKeyUsesShift,
            HotKeyUsesCtrl = HotKeyUsesCtrl,
            HotKeyUsesAlt = HotKeyUsesAlt,
            HotKeyKey = HotKeyKey
        };
    }
}