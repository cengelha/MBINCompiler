using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54CE8651B2495CA5, NameHash = 0x94F8E55312096B6B)]
    public class GcCustomisationPresets : NMSTemplate
    {
        /* 0x00 */ public List<GcCustomisationPreset> Presets;
        /* 0x10 */ public List<GcCustomisationDescriptorGroupFallbackData> DescriptorGroupFallbackMap;
    }
}
