using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItemInfo", menuName = "Inventory/Items/Create New ItemInfo")]
public class InventoryItemInfo : ScriptableObject, IInventoryItemInfo
{
    [SerializeField] private string _id;
    [SerializeField] private string _title;
    [SerializeField] private string _dicription;
    [SerializeField] private int _maxItemsInInventorySlot;
    [SerializeField] private Sprite _spriteIcon;

    public string id => _id;
    public string title => _title;
    public string dicription => _dicription;
    public int maxItemsInInventorySlot => _maxItemsInInventorySlot;
    public Sprite spriteIcon => _spriteIcon;
}