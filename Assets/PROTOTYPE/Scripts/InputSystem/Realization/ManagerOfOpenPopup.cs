using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ManagerOfOpenPopup : MonoBehaviour, IOpenPopup
{
    [SerializeField] private UIDocument _popupDocument;

    private VisualElement _container;
    private Dictionary<string, VisualElement> _containers = new Dictionary<string, VisualElement>();
    private bool _isPopupOpen;
    private string _prevKey;

    private void Awake()
    {
        var popupRootElement = _popupDocument.rootVisualElement;

        _containers.Add("escape", popupRootElement.Q<VisualElement>("PauseMenuContainer"));
        _containers.Add("i", popupRootElement.Q<VisualElement>("InventoryContainer"));
        _containers.Add("j", popupRootElement.Q<VisualElement>("DiaryContainer"));
        _containers.Add("m", popupRootElement.Q<VisualElement>("MapContainer"));

        _isPopupOpen = false;
    }

    public void OpenPopup(string key)
    {
        if (!_isPopupOpen)
        {
            _prevKey = key;
            _container = _containers[key];
            _container.style.display = DisplayStyle.Flex;
            StopGame();
            _isPopupOpen = true;
        }
        else if(key == _prevKey)
        {
            _container.style.display = DisplayStyle.None;
            ContinueGame();
            _isPopupOpen = false;
        }
    }

    private void StopGame()
    {
        Time.timeScale = 0f;
    }

    private void ContinueGame()
    {
        Time.timeScale = 1f;
    }
}