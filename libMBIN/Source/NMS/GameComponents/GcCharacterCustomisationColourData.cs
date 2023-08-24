using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46381A2DECBC5E2E, NameHash = 0x8AC0161286DB6A30)]
    public class GcCharacterCustomisationColourData : NMSTemplate
    {
        /* 0x00 */ public TkPaletteTexture Palette;
        /* 0x10 */ public Colour Colour;
    }
}
