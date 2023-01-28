using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

[Serializable]
public class ItemDetails
{
    public string Name;
    public string GUID;
    public Sprite Icon;
    public bool CanDrop;
}

public enum InventoryChangeType
{
    Pickup,
    Drop
}

public delegate void OnInventoryChangedDelegate(InventoryChangeType change);

public class GameController : MonoBehaviour
{
    [SerializeField] public List<Sprite> IconSprites;

    [SerializeField] private UIDocument _popupDocument;

    private static Dictionary<string, ItemDetails> _itemDatabase = new Dictionary<string, ItemDetails>();
    private List<ItemDetails> _playerInventory = new List<ItemDetails>();
    public static event OnInventoryChangedDelegate OnInventoryChanged = delegate { };

    private VisualElement _container;

    private List<VisualElement> _items = new List<VisualElement>();

    private void Awake()
    {
        var popupRootElement = _popupDocument.rootVisualElement;
        _container = popupRootElement.Q<VisualElement>("SlotContainer");
        _items = _container.Query<VisualElement>("Item").ToList();
        _items.ForEach(item =>
        {
            item.RegisterCallback<ClickEvent>(OnItemClicked);
        });

        //PopulateDatabase();
        OnInventoryChanged += GameController_OnInventoryChanged;
    }

    private void OnItemClicked(ClickEvent evt)
    {
        // Only perform this action at the target, not in a parent
        if (evt.propagationPhase != PropagationPhase.AtTarget)
            return;

        // Assign a random new color
        var targetBox = evt.target as VisualElement;
        targetBox.style.backgroundColor = GetRandomColor();
    }

    private Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f));
    }

    private void Start()
    {
        //var popupRootElement = _popupDocument.rootVisualElement;
        //_container = popupRootElement.Q<VisualElement>("SlotContainer");
        //_items = _container.Query<VisualElement>("Item").ToList();


        //_playerInventory.AddRange(_itemDatabase.Values);
        OnInventoryChanged.Invoke(InventoryChangeType.Pickup);
        for (int i = 0; i <= 20; i++)
        {
            _items[i].style.backgroundColor = Color.blue;
            Debug.Log(_items[i].resolvedStyle.backgroundImage);
        }
    }

    //public void PopulateDatabase()
    //{
    //    _itemDatabase.Add("8B0EF21A-F2D9-4E6F-8B79-031CA9E202BA", new ItemDetails()
    //    {
    //        Name = "History of the Syndicate: 1501 to 1825 ",
    //        GUID = "8B0EF21A-F2D9-4E6F-8B79-031CA9E202BA",
    //        Icon = IconSprites.FirstOrDefault(x => x.name.Equals("syndicate")),
    //        CanDrop = false
    //    });

    //    _itemDatabase.Add("992D3386-B743-4CD3-9BB7-0234A057C265", new ItemDetails()
    //    {
    //        Name = "Health Potion",
    //        GUID = "992D3386-B743-4CD3-9BB7-0234A057C265",
    //        Icon = IconSprites.FirstOrDefault(x => x.name.Equals("potion")),
    //        CanDrop = true
    //    });

    //    _itemDatabase.Add("1B9C6CAA-754E-412D-91BF-37F22C9A0E7B", new ItemDetails()
    //    {
    //        Name = "Bottle of Poison",
    //        GUID = "1B9C6CAA-754E-412D-91BF-37F22C9A0E7B",
    //        Icon = IconSprites.FirstOrDefault(x => x.name.Equals("poison")),
    //        CanDrop = true
    //    });

    //}

    //public static ItemDetails GetItemByGuid(string guid)
    //{
    //    if (_itemDatabase.ContainsKey(guid))
    //    {
    //        return _itemDatabase[guid];
    //    }

    //    return null;
    //}

    private void GameController_OnInventoryChanged(InventoryChangeType change)
    {
        //Loop through each item and if it has been picked up, add it to the next empty slot
            if (change == InventoryChangeType.Pickup)
            {
                //var emptySlot = InventoryItems.FirstOrDefault(x => x.ItemGuid.Equals(""));
                var emptySlot = _items.FirstOrDefault(x => x.style.backgroundImage.Equals(null));

                if (emptySlot != null)
                {
                    var a = emptySlot.style.backgroundImage;
                    Debug.Log(a);
                    //HoldItem(GetItemByGuid(item));
                }
            }
    }

    //private void HoldItem(ItemDetails item)
    //{
    //    Icon.image = item.Icon.texture;
    //    ItemGuid = item.GUID;
    //}
    //public void DropItem()
    //{
    //    ItemGuid = "";
    //    Icon.image = null;
    //}
}