using System;
using UnityEngine;

public interface ExpIInventoryItem
{
    string id { get; }
    string title { get; }
    string dicription { get; }

    Type type { get; }
    Sprite spriteIcon { get; }

    int amount { get; set; }
    int maxItemsInInventorySlot { get; }
    bool isEquipped { get; set; }

    IInventoryItem Clone();
}