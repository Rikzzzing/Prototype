using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCharacter : MonoBehaviour
{
    private IMovable _movable;
    private IJumpable _jumpable;
    private GameAction _gameAction;

    private void Awake()
    {
        if (_gameAction == null)
        {
            _gameAction = new GameAction();
        }

        _movable = GetComponent<IMovable>();
        _jumpable= GetComponent<IJumpable>();

        if (_movable == null)
        {
            throw new Exception($"There is no IMovable on the object: {gameObject.name}");
        }

        if (_jumpable == null)
        {
            throw new Exception($"There is no IJumpable on the object: {gameObject.name}");
        }
    }

    private void OnEnable()
    {
        _gameAction.Enable();
        _gameAction.Player.Jump.performed += OnJumpPerfermed;
    }

    private void OnJumpPerfermed(InputAction.CallbackContext obj)
    {
        _jumpable.Jump();
    }

    private void Update()
    {
        ReadMovement();
    }

    private void ReadMovement()
    {
        var inputDirection = _gameAction.Player.Move.ReadValue<Vector2>();
        var direction = new Vector3(inputDirection.x, 0f, inputDirection.y);

        _movable.Move(direction);
    }

    private void OnDisable()
    {
        _gameAction.Player.Jump.performed -= OnJumpPerfermed;
        _gameAction.Disable();
    }
}