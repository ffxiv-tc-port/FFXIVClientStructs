using FFXIVClientStructs.FFXIV.Client.System.Memory;

namespace FFXIVClientStructs.FFXIV.Component.GUI;

// Component::GUI::AtkComponentCheckBox
//   Component::GUI::AtkComponentButton
//     Component::GUI::AtkComponentBase
//       Component::GUI::AtkEventListener
// common CreateAtkComponent function "E8 ?? ?? ?? ?? 4C 8B F0 48 85 C0 0F 84 ?? ?? ?? ?? 49 8B 4D 08"
// type 3
[GenerateInterop]
[Inherits<AtkComponentButton>]
[StructLayout(LayoutKind.Explicit, Size = 0x110)]
// 台服：不用上游「跟 call 進元件工廠＋固定位移」；錨在工廠 CheckBox 分支的 vtable lea＋自有欄位清零，對不上＝解不出。
[VirtualTable("48 8D 05 ?? ?? ?? ?? 0F 57 C0 48 89 07 48 8B DF 33 C0 0F 11 87 F0 00 00 00 48 89 87 00 01 00 00 89 87 08 01 00 00", 3)]
public unsafe partial struct AtkComponentCheckBox : ICreatable {
    public void Ctor() {
        AtkComponentButton.Ctor();
        VirtualTable = StaticVirtualTablePointer;
    }
}
