using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA00AE1E05ADB23CE, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x10 */ public GcRewardTableCategory[] Rarities;
    }
}
