using UnityEngine;
using UnityEngine.UIElements;

public class ManagerOfOpenPopup : MonoBehaviour, IOpenPopup
{
    [SerializeField] private UIDocument _inventoryDocument;
    [SerializeField] private UIDocument _diaryDocument;
    [SerializeField] private UIDocument _mapDocument;

    private VisualElement _inventoryContainer;
    private VisualElement _diaryContainer;
    private VisualElement _mapContainer;

    private bool _isInventoryOpen;
    private bool _isDiaryOpen;
    private bool _isMapOpen;

    private void Awake()
    {
        var inventoryRootElement = _inventoryDocument.rootVisualElement;
        var diaryRootElement = _diaryDocument.rootVisualElement;
        var mapRootElement = _mapDocument.rootVisualElement;

        _inventoryContainer = inventoryRootElement.Q<VisualElement>("Container");
        _diaryContainer = diaryRootElement.Q<VisualElement>("Container");
        _mapContainer = mapRootElement.Q<VisualElement>("Container");

        _isInventoryOpen = false;
        _isDiaryOpen = false;
        _isMapOpen = false;
    }

    public void OpenInventory()
    {
        if (!_isInventoryOpen)
        {
            _inventoryContainer.style.display = DisplayStyle.Flex;
        }
        else
        {
            _inventoryContainer.style.display = DisplayStyle.None;
        }

        _isInventoryOpen = !_isInventoryOpen;
    }

    public void OpenDiary()
    {
        if (!_isDiaryOpen)
        {
            _diaryContainer.style.display = DisplayStyle.Flex;
        }
        else
        {
            _diaryContainer.style.display = DisplayStyle.None;
        }

        _isDiaryOpen = !_isDiaryOpen;
    }

    public void OpenMap()
    {
        if (!_isMapOpen)
        {
            _mapContainer.style.display = DisplayStyle.Flex;
        }
        else
        {
            _mapContainer.style.display = DisplayStyle.None;
        }

        _isMapOpen = !_isMapOpen;
    }
}