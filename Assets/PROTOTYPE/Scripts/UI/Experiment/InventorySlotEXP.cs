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
    public void HoldItem(ItemDetails item)
    {
        Icon.image = item.Icon.texture;
        ItemGuid = item.GUID;
    }
    public void DropItem()
    {
        ItemGuid = "";
        Icon.image = null;
    }
}