using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCharacter : MonoBehaviour
{
    private IControlable _controlable;
    private GameAction _gameAction;

    private void Awake()
    {
        if (_gameAction == null)
        {
            _gameAction = new GameAction();
        }
        _gameAction.Enable();

        _controlable = GetComponent<IControlable>();

        if (_controlable == null)
        {
            throw new Exception($"There is no IControlable on the object: {gameObject.name}");
        }
    }

    private void OnEnable()
    {
        _gameAction.Gameplay.Jump.performed += OnJumpPerfermed;
    }

    private void OnJumpPerfermed(InputAction.CallbackContext obj)
    {
        _controlable.Jump();
    }

    private void Update()
    {
        ReadMovement();
    }

    private void ReadMovement()
    {
        var inputDirection = _gameAction.Gameplay.Movement.ReadValue<Vector2>();
        var direction = new Vector3(inputDirection.x, 0f, inputDirection.y);

        _controlable.Move(direction);
    }

    private void OnDisable()
    {
        _gameAction.Gameplay.Jump.performed -= OnJumpPerfermed;
        _gameAction.Disable();
    }
}