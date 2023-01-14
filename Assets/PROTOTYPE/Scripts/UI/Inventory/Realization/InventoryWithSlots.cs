using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class InventoryWithSlots : IInventory
{
    public event Action<object, IInventoryItem, int> OnInventoryItemAddedEvent;
    public event Action<object, Type, int> OnInventoryItemRemovedEvent;

    private List<IInventorySlot> _slots;
    public int capacityOfInventory { get; set; }
    public bool isFull => _slots.All(slot => slot.isFull);

    public InventoryWithSlots(int capacity)
    {
        capacityOfInventory = capacity;
        _slots = new List<IInventorySlot>(capacity);

        for (int i = 0; i < capacity; i++)
        {
            _slots.Add(new InventorySlot());
        }
    }

    public IInventoryItem GetItem(Type itemType)
    {
        return _slots.Find(slot => slot.itemType == itemType).itemInSlot;
    }

    public IInventoryItem[] GetAllItems()
    {
        var allItems = new List<IInventoryItem>();

        foreach (var slot in _slots)
        {
            if (!slot.isEmpty)
            {
                allItems.Add(slot.itemInSlot);
            }
        }

        return allItems.ToArray();
    }

    public IInventoryItem[] GetAllItems(Type itemType)
    {
        var allItemsOfType = new List<IInventoryItem>();
        var slotsOfType = _slots.FindAll(slot => !slot.isEmpty && slot.itemType == itemType);

        foreach (var slot in slotsOfType)
        {
            allItemsOfType.Add(slot.itemInSlot);
        }

        return allItemsOfType.ToArray();
    }

    public IInventoryItem[] GetEqippedItems()
    {
        var requiredSlots = _slots.FindAll(slot => !slot.isEmpty && slot.itemInSlot.isEquipped);
        var equippedItems = new List<IInventoryItem>();

        foreach (var slot in requiredSlots)
        {
            equippedItems.Add(slot.itemInSlot);
        }

        return equippedItems.ToArray();
    }

    public int GetItemAmount(Type itemType)
    {
        var amount = 0;
        var allItemSlots = _slots.FindAll(slot => !slot.isEmpty && slot.itemType == itemType);

        foreach (var itemSlot in allItemSlots)
        {
            amount += itemSlot.amountItemsInSlot;
        }

        return amount;
    }

    public bool TryToAdd(object sender, IInventoryItem item)
    {
        var slotWithSameItemButNotEmpty = _slots.
            Find(slot => !slot.isEmpty && slot.itemType == item.type && !slot.isFull);

        if (slotWithSameItemButNotEmpty != null)
        {
            return TryAddToSlot(sender, slotWithSameItemButNotEmpty, item);
        }

        var emptySlot = _slots.Find(slot => slot.isEmpty);

        if (emptySlot != null)
        {
            return TryAddToSlot(sender, emptySlot, item);
        }

        Debug.Log($"Cannot add item ({item.type}), amount: {item.amount}, because there is mo place for that.");
        return false;
    }

    private bool TryAddToSlot(object sender, IInventorySlot slot, IInventoryItem item)
    {
        var fits = slot.amountItemsInSlot + item.amount <= item.maxItemsInInventorySlot;
        var amountToAdd = fits ? item.amount : item.maxItemsInInventorySlot - slot.amountItemsInSlot;
        var amountLeft = item.amount - amountToAdd;
        var clonedItem = item.Clone();

        clonedItem.amount = amountToAdd;

        if (slot.isEmpty)
        {
            slot.SetItem(clonedItem);
        }
        else
        {
            slot.itemInSlot.amount += amountToAdd;
        }

        Debug.Log($"Item added to inventoru. ItemType: ({item.type}), amount: {amountToAdd}");
        OnInventoryItemAddedEvent?.Invoke(sender, item, amountToAdd);

        if (amountLeft <= 0)
        {
            return true;
        }

        item.amount = amountLeft;
        return TryToAdd(sender, item);
    }

    public void TryToRemove(object sender, Type itemType, int amount = 1)
    {
        var slotsWithItem = GetAllSlots(itemType);

        if (slotsWithItem.Length == 0)
        {
            return;
            //return false;
        }

        var amountToRemove = amount;
        var count = slotsWithItem.Length;

        for (int i = count - 1; i >= 0; i--)
        {
            var slot = slotsWithItem[i];

            if (slot.amountItemsInSlot >= amountToRemove)
            {
                slot.itemInSlot.amount -= amountToRemove;

                if (slot.amountItemsInSlot <= 0)
                {
                    slot.Clear();
                }

                Debug.Log($"Item removed from inventoru. ItemType: ({itemType}), amount: {amountToRemove}");
                OnInventoryItemRemovedEvent?.Invoke(sender, itemType, amountToRemove);

                break;
            }

            var amountRemoved = slot.amountItemsInSlot;
            amountToRemove -= slot.amountItemsInSlot;
            slot.Clear();

            Debug.Log($"Item removed from inventoru. ItemType: ({itemType}), amount: {amountRemoved}");
            OnInventoryItemRemovedEvent?.Invoke(sender, itemType, amountRemoved);
        }

        //return TryToRemove(sender, itemType);
    }

    public IInventorySlot[] GetAllSlots(Type itemType)
    {
        return _slots.FindAll(slot => !slot.isEmpty && slot.itemType == itemType).ToArray();
    }

    public bool HasItem(Type itemType, out IInventoryItem item)
    {
        item = GetItem(itemType);
        return item != null;
    }

    public IInventorySlot[] GetAllSlots()
    {
        return _slots.ToArray();
    }
}