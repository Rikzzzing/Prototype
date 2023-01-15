using UnityEngine.Scripting;
using UnityEngine.UIElements;

public class InventorySlotEXP : VisualElement
{
    public Image Icon;
    public string ItemGuid = "";

    public InventorySlotEXP()
    {
        Icon = new Image();
        Add(Icon);
        Icon.AddToClassList("inventory-slot-icon");
        AddToClassList("inventory-slot");
    }

    #region UXML
    [Preserve]
    public new class UxmlFactory : UxmlFactory<InventorySlotEXP, UxmlTraits> { }
    [Preserve]
    public new class UxmlTraits : VisualElement.UxmlTraits { }
    #endregion
}