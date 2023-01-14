using System;

public interface IInventoryItem
{
    Type type { get; }
    bool isEquipped { get; set; }
    int maxItemsInInventorySlot { get; }
    int amount { get; set; }

    IInventoryItem Clone();
}