using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private GameAction _gameAction;
    private Vector2 movementInput;

    private void Awake()
    {
        if (_gameAction == null)
        {
            _gameAction = new GameAction();
        }
        _gameAction.Enable();
    }

    private void OnEnable()
    {
        //_gameAction.Gameplay.Jump.performed += OnJumpPerfermed; 
        //_gameAction.Gameplay.Movement.performed +=

    }

    private void OnJumpPerfermed()
    {

    }

    private void OnDisable()
    {
        _gameAction.Disable();
    }
}