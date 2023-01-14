using System;

public interface IInventory
{
    int capacityOfInventory { get; set; }
    bool isFull { get; }

    IInventoryItem GetItem(Type itemType);
    IInventoryItem[] GetAllItems();
    IInventoryItem[] GetAllItems(Type itemType);
    IInventoryItem[] GetEqippedItems();

    int GetItemAmount(Type itemType);
    bool TryToAdd(object sender, IInventoryItem item);
    bool TryToRemove(object sender, Type itemType, int amount = 1);
    bool HasItem(Type itemType, out IInventoryItem item);
}