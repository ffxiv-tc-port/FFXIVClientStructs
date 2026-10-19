using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::AddonGSInfoCardList
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[Addon("GSInfoCardList")]
[GenerateInterop]
[Inherits<AtkUnitBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x560)]
public unsafe partial struct AddonGSInfoCardList {
    [FieldOffset(0x2B0)] public TabController TabController;

    [FieldOffset(0x360)] public AtkResNode* PageSelection;

    [FieldOffset(0x368), FixedSizeArray] internal FixedSizeArray9<Pointer<AtkComponentButton>> _pageButtons;

    [FieldOffset(0x3B0)] public AtkComponentButton* GotoFirstPageButton;
    [FieldOffset(0x3B8)] public AtkComponentButton* GotoLastPageButton;

    [FieldOffset(0x3D0), FixedSizeArray] internal FixedSizeArray30<Pointer<AtkComponentButton>> _cardButtons;

    [FieldOffset(0x4C0)] public AtkTextNode* TotalTextNode;
    [FieldOffset(0x4C8)] public AtkImageNode* SelectedButtonBorderImage;
    [FieldOffset(0x4D0)] public AtkComponentDropDownList* CardDisplayFilter;
    // TC 7.25 layout (same as the 7.4-era upstream except SelectedCardIndex): text/image nodes start at 0x4F0.
    [FieldOffset(0x4F0)] public AtkTextNode* SelectedCardName;
    [FieldOffset(0x4F8)] public AtkTextNode* SelectedCardTribeName;
    [FieldOffset(0x500)] public AtkTextNode* SelectedCardDescription;
    [FieldOffset(0x508)] public AtkTextNode* PreviewedCardNumber;
    [FieldOffset(0x510)] public AtkTextNode* SelectedCardNumber;
    [FieldOffset(0x518)] public AtkTextNode* SelectedCardAcquisitionName;
    [FieldOffset(0x520)] public AtkImageNode* SelectedCardAcquisitionIcon;

    // Kept only so plugins compiled against the old layout still bind; the TC addon stores no filter int (0x520 is the icon node pointer).
    [FieldOffset(0x520), Obsolete("TC client has no filter-mode field; read CardDisplayFilter instead. This aliases the low half of SelectedCardAcquisitionIcon.")]
    public GSInfoCardListFilterMode FilterMode;
    [FieldOffset(0x528)] public int TotalPages;
    [FieldOffset(0x52C)] public int RequestedPage;
    /// <remarks> 0-indexed; synced from RequestedPage at the end of OnRefresh. </remarks>
    [FieldOffset(0x530)] public int SelectedPage;
    [FieldOffset(0x534)] public int SelectedCardIndex; // 0-29, does not account for page
}

public enum GSInfoCardListFilterMode {
    DisplayAllCards = 0xE,
    DisplayOwnedCards = 0x6,
    DisplayUnownedCards = 0x9,
}
