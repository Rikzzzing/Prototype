using System;

public class InventorySlot : IInventorySlot
{
    public bool isFull => amountItemsInSlot == capacityOfSlot;
    public bool isEmpty => itemInSlot == null;
    public int amountItemsInSlot => isEmpty ? 0 : itemInSlot.state.amount;
    public int capacityOfSlot { get; private set; }

    public IInventoryItem itemInSlot { get; private set; }
    public Type itemType => itemInSlot.type;

    public void SetItem(IInventoryItem item)
    {
        if (!isEmpty)
        {
            return;
        }

        itemInSlot = item;
        capacityOfSlot = itemInSlot.info.maxItemsInInventorySlot;
    }

    public void Clear()
    {
        if (!isEmpty)
        {
            return;
        }

        itemInSlot.state.amount = 0;
        itemInSlot = null;
    }

}