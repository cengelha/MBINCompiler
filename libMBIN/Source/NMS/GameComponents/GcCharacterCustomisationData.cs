using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDAC68072C02161A, NameHash = 0xBF5911FBC471448F)]
    public class GcCharacterCustomisationData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> DescriptorGroups;
        /* 0x10 */ public List<GcCharacterCustomisationColourData> Colours;
        /* 0x20 */ public List<GcCharacterCustomisationTextureOptionData> TextureOptions;
        /* 0x30 */ public List<GcCharacterCustomisationBoneScaleData> BoneScales;
        /* 0x40 */ public float Scale;
    }
}
