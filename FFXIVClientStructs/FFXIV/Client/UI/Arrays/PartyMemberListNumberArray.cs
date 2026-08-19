using FFXIVClientStructs.FFXIV.Client.UI.Arrays.Common;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Arrays;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 633 * 4)]
public unsafe partial struct PartyMemberListNumberArray {
    public static PartyMemberListNumberArray* Instance() {
        var stage = AtkStage.Instance();
        if (stage == null) return null;
        var numberArray = stage->GetNumberArrayData(NumberArrayType.PartyMemberList);
        return numberArray == null ? null : (PartyMemberListNumberArray*)numberArray->IntArray;
    }

    [FieldOffset(0 * 4), FixedSizeArray, CExporterIgnore] internal FixedSizeArray633<int> _data;

    [FieldOffset(0 * 4), FixedSizeArray] internal FixedSizeArray48<SocialListMemberNumberArray> _partyMembers;
}
