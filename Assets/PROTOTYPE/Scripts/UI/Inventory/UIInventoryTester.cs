using System.Collections.Generic;
using UnityEngine;

public class UIInventoryTester
{
    private InventoryItemInfo _appleInfo;
    private InventoryItemInfo _papperInfo;
    private UIInventorySlot[] _uiSlots;

    public InventoryWithSlots inventory { get; }

    public UIInventoryTester(InventoryItemInfo appleInfo, InventoryItemInfo papperInfo, UIInventorySlot[] uiSlots)
    {
        _appleInfo = appleInfo;
        _papperInfo = papperInfo;
        _uiSlots = uiSlots;

        inventory = new InventoryWithSlots(15);
        inventory.OnInventoryStateChangedEvent += OnInventoryStateChanged;
    }

    public void FillSlots()
    {
        var allSlots = inventory.GetAllSlots();
        var availableSlots = new List<IInventorySlot>(allSlots);

        var filledSlots = 5;

        for (int i = 0; i < filledSlots; i++)
        {
            var filledSlot = AddRandomApplesIntoRandomSlot(availableSlots);
            availableSlots.Remove(filledSlot);

            filledSlot = AddRandomPeppersIntoRandomSlot(availableSlots);
            availableSlots.Remove(filledSlot);
        }

        SetupInventoryUI(inventory);
    }

    private IInventorySlot AddRandomApplesIntoRandomSlot(List<IInventorySlot> slots)
    {
        var randomSlotIndex = Random.Range(0, slots.Count);
        var randomSlot = slots[randomSlotIndex];
        var randomCount = Random.Range(1, 4);
        var apple = new Apple(_appleInfo);
        apple.state.amount = randomCount;
        inventory.TryToAddToSlot(this, randomSlot, apple);
        return randomSlot;
    }

    private IInventorySlot AddRandomPeppersIntoRandomSlot(List<IInventorySlot> slots)
    {
        var randomSlotIndex = Random.Range(0, slots.Count);
        var randomSlot = slots[randomSlotIndex];
        var randomCount = Random.Range(1, 4);
        var pepper = new Pepper(_papperInfo);
        pepper.state.amount = randomCount;
        inventory.TryToAddToSlot(this, randomSlot, pepper);
        return randomSlot;
    }

    private void SetupInventoryUI(InventoryWithSlots inventory)
    {
        var allSlots = inventory.GetAllSlots();
        var allSlotsCount = allSlots.Length;

        for (int i = 0; i< allSlotsCount; i++)
        {
            var slot = allSlots[i];
            var uiSlot = _uiSlots[i];
            uiSlot.SetSlot(slot);
            uiSlot.Refresh();
        }
    }

    private void OnInventoryStateChanged(object sender)
    {
        foreach (var uiSlot in _uiSlots)
        {
            uiSlot.Refresh();
        }
    }
}