using FFXIVClientStructs.FFXIV.Client.System.Memory;

namespace FFXIVClientStructs.FFXIV.Component.GUI;
// Component::GUI::AtkComponentDropDownList
//   Component::GUI::AtkComponentBase
//     Component::GUI::AtkEventListener

[GenerateInterop]
[Inherits<AtkComponentBase>]
[StructLayout(LayoutKind.Explicit, Size = 0xE0)]
// 台服：上游 [1, 1345] 是固定位移跳進元件工廠函式，台服排版不同會跟到映像外。
// 改錨在工廠 DropDownList 分支的 vtable lea＋ShowPreview=true 初始化（對不上＝解不出，不會跳錯）。
[VirtualTable("48 8D 0D ?? ?? ?? ?? 48 89 58 10 48 89 58 18 48 89 58 20 48 89 58 28 48 89 58 30 48 89 58 38 48 89 58 40 C7 80 D8 00 00 00 00 00 01 00", 3)]
public unsafe partial struct AtkComponentDropDownList : ICreatable {
    [FieldOffset(0xC0)] public AtkComponentCheckBox* Checkbox;
    [FieldOffset(0xC8)] public AtkComponentList* List;

    [FieldOffset(0xD8)] public bool IsOpen;
    [FieldOffset(0xD9)] public bool OpenStateChangePending;
    [FieldOffset(0xDA)] public bool ShowPreview;

    [MemberFunction("E8 ?? ?? ?? ?? 44 03 FE")]
    public partial void SelectItem(int index);

    [MemberFunction("E8 ?? ?? ?? ?? 88 9F ?? ?? ?? ?? E9 ?? ?? ?? ?? 48 8B 87 ?? ?? ?? ??")]
    public partial void DeselectItem();

    [MemberFunction("E8 ?? ?? ?? ?? 83 C0 41")]
    public partial int GetSelectedItemIndex();

    public void Ctor() {
        AtkComponentBase.Ctor();
        VirtualTable = StaticVirtualTablePointer;
        ShowPreview = true;
    }
}
