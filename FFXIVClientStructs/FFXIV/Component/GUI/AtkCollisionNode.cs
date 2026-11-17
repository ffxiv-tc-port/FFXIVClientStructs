using FFXIVClientStructs.FFXIV.Client.System.Memory;

namespace FFXIVClientStructs.FFXIV.Component.GUI;

// Component::GUI::AtkCollisionNode
//   Component::GUI::AtkResNode
//     Component::GUI::AtkEventTarget
// common CreateAtkNode function "E8 ?? ?? ?? ?? 49 8B 55 ?? 0F B7 CD"
// type 8
[GenerateInterop]
[Inherits<AtkResNode>]
[StructLayout(LayoutKind.Explicit, Size = 0xC0)]
// 台服：不用上游「跟 call 進節點工廠＋固定位移」；錨在 Counter 分支後兩個 0xC0 分支（接預設分支）的第一個，對不上＝解不出。
[VirtualTable("48 8D 8B C8 00 00 00 48 89 03 E8 ?? ?? ?? ?? 48 8B C3 48 83 C4 20 5B C3 45 33 C9 4C 8B C0 33 D2 B9 C0 00 00 00 E8 ?? ?? ?? ?? 48 8B D8 48 85 C0 0F 84 ?? ?? ?? ?? 48 8B C8 E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? 48 89 03 48 8B C3 48 83 C4 20 5B C3 45 33 C9 4C 8B C0 33 D2 B9 C0 00 00 00 E8 ?? ?? ?? ?? 48 8B D8 48 85 C0 0F 84 ?? ?? ?? ?? 48 8B C8 E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? 48 89 03 48 8B C3 48 83 C4 20 5B C3 81 FB E8 03 00 00", 65)]
public unsafe partial struct AtkCollisionNode : ICreatable {
    [FieldOffset(0xB0)] public CollisionType CollisionType;
    [FieldOffset(0xB2)] public ushort Uses;
    [FieldOffset(0xB8)] public AtkComponentBase* LinkedComponent;

    // 7.0 inlines this ctor
    public void Ctor() {
        AtkResNode.Ctor();
        VirtualTable = StaticVirtualTablePointer;
    }
}

public enum CollisionType : ushort {
    Hit = 0x0,
    Focus = 0x1,
    Move = 0x2
}
