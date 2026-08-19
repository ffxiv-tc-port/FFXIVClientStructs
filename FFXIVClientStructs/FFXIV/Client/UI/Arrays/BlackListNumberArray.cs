using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Arrays;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 8 * 4)]
public unsafe partial struct BlackListNumberArray {
    public static BlackListNumberArray* Instance() {
        var stage = AtkStage.Instance();
        if (stage == null) return null;
        var numberArray = stage->GetNumberArrayData(NumberArrayType.BlackList);
        return numberArray == null ? null : (BlackListNumberArray*)numberArray->IntArray;
    }

    [FieldOffset(0), FixedSizeArray, CExporterIgnore] internal FixedSizeArray8<int> _data;

    [FieldOffset(0 * 4)] public int BlackListCount;
}
