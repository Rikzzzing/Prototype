//using UnityEngine;
//using UnityEngine.UIElements;
//using System.Collections.Generic;
//using System.Linq;

//public class InventoryUIController : MonoBehaviour
//{
//    public List<InventorySlotEXP> InventoryItems = new List<InventorySlotEXP>();
    
//    private void Awake()
//    {
//        GameController.OnInventoryChanged += GameController_OnInventoryChanged;
//    }

//    //private void GameController_OnInventoryChanged(InventoryChangeType change)
//    //{
//    //        if (change == InventoryChangeType.Pickup)
//    //        {
//    //            var emptySlot = InventoryItems.FirstOrDefault(x => x.ItemGuid.Equals(""));

//    //            if (emptySlot != null)
//    //            {
//    //                emptySlot.HoldItem(GameController.GetItemByGuid(item));
//    //            }
//    //        }
//    //}
//}