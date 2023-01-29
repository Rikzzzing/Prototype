using System;
using UnityEngine;

public class InputTPFCamera : MonoBehaviour
{
    private IMovable _movable;
    private GameAction _gameAction;

    private void Awake()
    {
        if (_gameAction == null)
        {
            _gameAction = new GameAction();
        }

        _movable = GetComponent<IMovable>();

        if (_movable == null)
        {
            throw new Exception($"There is no IMovable on the object: {gameObject.name}");
        }
    }

    private void OnEnable()
    {
        _gameAction.Enable();
    }

    private void Update()
    {
        ReadTPFCameraMovement();
    }

    private void ReadTPFCameraMovement()
    {
        var inputDirection = _gameAction.Player.Move.ReadValue<Vector2>();
        var direction = new Vector3(inputDirection.x, 0f, inputDirection.y);

        _movable.Move(direction);
    }

    private void OnDisable()
    {
        _gameAction.Disable();
    }
}