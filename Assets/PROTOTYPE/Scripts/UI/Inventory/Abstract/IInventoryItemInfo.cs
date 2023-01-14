using UnityEngine;

public interface IInventoryItemInfo
{
    string id { get; }
    string title { get; }
    string dicription { get; }
    int maxItemsInInventorySlot { get; }
    Sprite spriteIcon { get; }
}