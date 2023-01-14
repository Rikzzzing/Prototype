using System;

public interface IInventorySlot
{
    bool isFull { get; }
    bool isEmpty { get; }
    int amountItemsInSlot { get; }
    int capacityOfSlot { get; }

    IInventoryItem itemInSlot { get; }
    Type itemType { get; }

    void SetItem(IInventoryItem item);
    void Clear();
}