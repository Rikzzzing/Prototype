using System;

public class Pepper : IInventoryItem
{
    public IInventoryItemInfo info { get; }
    public IInventoryItemState state { get; }
    public Type type { get; }

    public Pepper(IInventoryItemInfo info)
    {
        this.info = info;
        state = new InventoryItemState();
    }

    public IInventoryItem Clone()
    {
        var clonnedPepper = new Pepper(info);
        clonnedPepper.state.amount = state.amount;
        return clonnedPepper;
    }
}