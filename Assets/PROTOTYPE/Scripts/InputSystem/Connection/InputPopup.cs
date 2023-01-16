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

        _gameAction.OpenPopup.OpenInventory.performed += OnOpenPopup;
        _gameAction.OpenPopup.OpenMap.performed += OnOpenPopup;
        _gameAction.OpenPopup.OpenDiary.performed += OnOpenPopup;
        _gameAction.OpenPopup.OpenPauseMenu.performed += OnOpenPopup;

    }

    private void OnOpenPopup(InputAction.CallbackContext obj)
    {
        _openPopup.OpenPopup(obj.control.name);
    }


    private void OnDisable()
    {
        _gameAction.OpenPopup.OpenInventory.performed -= OnOpenPopup;
        _gameAction.OpenPopup.OpenMap.performed -= OnOpenPopup;
        _gameAction.OpenPopup.OpenDiary.performed -= OnOpenPopup;
        _gameAction.OpenPopup.OpenPauseMenu.performed -= OnOpenPopup;

        _gameAction.Disable();
    }
}