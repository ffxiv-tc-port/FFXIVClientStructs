using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Arrays;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 25 * 4)]
public unsafe partial struct ConfigSystemNumberArray {
    public static ConfigSystemNumberArray* Instance() {
        var stage = AtkStage.Instance();
        if (stage == null) return null;
        var numberArray = stage->GetNumberArrayData(NumberArrayType.ConfigSystem);
        return numberArray == null ? null : (ConfigSystemNumberArray*)numberArray->IntArray;
    }

    [FieldOffset(0), FixedSizeArray, CExporterIgnore] internal FixedSizeArray25<int> _data;

    [FieldOffset(0 * 4)] public int FPS;
}
