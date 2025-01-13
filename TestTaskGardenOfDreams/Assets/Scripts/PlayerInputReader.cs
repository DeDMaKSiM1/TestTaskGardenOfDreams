using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    private Player _player;
    private PlayerInputAction _inputAction;
    private Vector2 _movement;

    private void Awake()
    {
        _inputAction = new PlayerInputAction();
        _inputAction.Player.Move.performed += OnMove;
        _inputAction.Player.Move.canceled += OnMove;

        _inputAction.Player.Attack.performed += OnAttack;

        _player = GetComponent<Player>();
    }

    private void OnEnable()
    {
        _inputAction.Enable();
    }

    private void OnDisable()
    {
        _inputAction.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _movement = context.ReadValue<Vector2>();
        _player.SetDirection(_movement);
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        //_player.Attack();
    }
}
