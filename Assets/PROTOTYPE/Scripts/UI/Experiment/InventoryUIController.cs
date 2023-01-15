using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;

public class InventoryUIController : MonoBehaviour
{
    public List<InventorySlotEXP> InventoryItems = new List<InventorySlotEXP>();
    private VisualElement _root;
    private VisualElement _slotContainer;
    
    private void Awake()
    {
        _root = GetComponent<UIDocument>().rootVisualElement;
        _slotContainer = _root.Q<VisualElement>("SlotContainer");

        for (int i = 0; i < 24; i++)
        {
            InventorySlotEXP item = new InventorySlotEXP();
            InventoryItems.Add(item);
            _slotContainer.Add(item);
        }
    }
}