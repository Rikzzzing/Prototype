using System;

public class Apple : IInventoryItem
{
    public Type type => GetType();

    public bool isEquipped { get; set; }

    public int maxItemsInInventorySlot { get; }

    public int amount { get; set; }

    public Apple(int maxItemsInSlotOfInventory)
    {
        maxItemsInInventorySlot = maxItemsInSlotOfInventory;
    }

    public IInventoryItem Clone()
    {
        return new Apple(maxItemsInInventorySlot)
        {
            amount = this.amount
        };
    }
}