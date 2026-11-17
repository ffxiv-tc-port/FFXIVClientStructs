using FFXIVClientStructs.FFXIV.Client.System.Memory;

namespace FFXIVClientStructs.FFXIV.Component.GUI;

// Component::GUI::AtkNineGridNode
//   Component::GUI::AtkResNode
//     Component::GUI::AtkEventTarget
// common CreateAtkNode function "E8 ?? ?? ?? ?? 49 8B 55 ?? 0F B7 CD"
// type 4
[GenerateInterop]
[Inherits<AtkResNode>]
[StructLayout(LayoutKind.Explicit, Size = 0xD0)]
[VirtualTable("48 8D 8B C0 00 00 00 48 89 03 E8 ?? ?? ?? ?? 48 8B C3 48 83 C4 20 5B C3 45 33 C9 4C 8B C0 33 D2 B9 D0 00 00 00 E8 ?? ?? ?? ?? 48 8B D8 48 85 C0 0F 84 ?? ?? ?? ?? 48 8B C8 E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? 48 89 03", 65)]
public unsafe partial struct AtkNineGridNode : ICreatable {
    [FieldOffset(0xB0)] public AtkUldPartsList* PartsList;
    [FieldOffset(0xB8)] public uint PartId;
    [FieldOffset(0xBC)] public short TopOffset;
    [FieldOffset(0xBE)] public short BottomOffset;
    [FieldOffset(0xC0)] public short LeftOffset;
    [FieldOffset(0xC2)] public short RightOffset;
    [FieldOffset(0xC4)] public uint BlendMode;

    // bit 1 = parts type, bit 2 = render type
    [FieldOffset(0xC8)] public byte PartsTypeRenderType;

    // 7.0 inlines this ctor
    public void Ctor() {
        AtkResNode.Ctor();
        VirtualTable = StaticVirtualTablePointer;
    }
}
