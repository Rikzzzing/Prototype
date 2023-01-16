using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

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

public delegate void OnInventoryChangedDelegate(string[] itemGuid, InventoryChangeType change);

public class GameController : MonoBehaviour
{
    [SerializeField]
    public List<Sprite> IconSprites;
    private static Dictionary<string, ItemDetails> _itemDatabase = new Dictionary<string, ItemDetails>();
    private List<ItemDetails> _playerInventory = new List<ItemDetails>();
    public static event OnInventoryChangedDelegate OnInventoryChanged = delegate { };


    private void Awake()
    {
        PopulateDatabase();
    }

    private void Start()
    {
        _playerInventory.AddRange(_itemDatabase.Values);
        OnInventoryChanged.Invoke(_playerInventory.Select(x => x.GUID).ToArray(), InventoryChangeType.Pickup);
    }

    public void PopulateDatabase()
    {
        _itemDatabase.Add("8B0EF21A-F2D9-4E6F-8B79-031CA9E202BA", new ItemDetails()
        {
            Name = "History of the Syndicate: 1501 to 1825 ",
            GUID = "8B0EF21A-F2D9-4E6F-8B79-031CA9E202BA",
            Icon = IconSprites.FirstOrDefault(x => x.name.Equals("syndicate")),
            CanDrop = false
        });

        _itemDatabase.Add("992D3386-B743-4CD3-9BB7-0234A057C265", new ItemDetails()
        {
            Name = "Health Potion",
            GUID = "992D3386-B743-4CD3-9BB7-0234A057C265",
            Icon = IconSprites.FirstOrDefault(x => x.name.Equals("potion")),
            CanDrop = true
        });

        _itemDatabase.Add("1B9C6CAA-754E-412D-91BF-37F22C9A0E7B", new ItemDetails()
        {
            Name = "Bottle of Poison",
            GUID = "1B9C6CAA-754E-412D-91BF-37F22C9A0E7B",
            Icon = IconSprites.FirstOrDefault(x => x.name.Equals("poison")),
            CanDrop = true
        });

    }

    public static ItemDetails GetItemByGuid(string guid)
    {
        if (_itemDatabase.ContainsKey(guid))
        {
            return _itemDatabase[guid];
        }

        return null;
    }
}