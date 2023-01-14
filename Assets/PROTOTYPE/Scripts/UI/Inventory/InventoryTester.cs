using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTester : MonoBehaviour
{
    private IInventory _inventory;
    private IInventoryItemInfo info;

    private void Awake()
    {
        var capacityOfInventory = 10;

        _inventory = new InventoryWithSlots(capacityOfInventory);
        Debug.Log($"Inventory initialized, capacity: {capacityOfInventory}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddRandomApples();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RemoveRandomApples();
        }
    }

    private void AddRandomApples()
    {
        var randomCount = Random.Range(0, 5);
        var apple = new Apple(info);
        apple.state.amount = randomCount;
        _inventory.TryToAdd(this, apple);
    }

    private void RemoveRandomApples()
    {
        var randomCount = Random.Range(0, 10);
        _inventory.TryToRemove(this, typeof(Apple), randomCount);
    }
}