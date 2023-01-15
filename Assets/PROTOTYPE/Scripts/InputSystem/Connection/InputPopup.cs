using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPopup : MonoBehaviour
{
    private IOpenPopup _openPopup;
    private GameAction _gameAction;

    private void Awake()
    {
        if (_gameAction == null)
        {
            _gameAction = new GameAction();
        }

        _openPopup = GetComponent<IOpenPopup>();

        if (_openPopup == null)
        {
            throw new Exception($"There is no IOpenPopup on the object: {gameObject.name}");
        }
    }

    private void OnEnable()
    {
        _gameAction.Enable();
        _gameAction.Player.OpenInventory.performed += OnOpenInventoryPerfermed;
        _gameAction.Player.OpenMap.performed += OnOpenMapPerfermed;
        _gameAction.Player.OpenDiary.performed += OnOpenDiaryPerfermed;
    }

    private void OnOpenInventoryPerfermed(InputAction.CallbackContext obj)
    {
        _openPopup.OpenInventory();
    }

    private void OnOpenMapPerfermed(InputAction.CallbackContext obj)
    {
        _openPopup.OpenMap();
    }

    private void OnOpenDiaryPerfermed(InputAction.CallbackContext obj)
    {
        _openPopup.OpenDiary();
    }

    private void OnDisable()
    {
        _gameAction.Player.OpenInventory.performed -= OnOpenInventoryPerfermed;
        _gameAction.Player.OpenMap.performed -= OnOpenMapPerfermed;
        _gameAction.Player.OpenDiary.performed -= OnOpenDiaryPerfermed;
        _gameAction.Disable();
    }
}