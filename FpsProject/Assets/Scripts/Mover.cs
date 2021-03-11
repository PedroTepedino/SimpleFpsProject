    using UnityEngine;
using UnityEngine.InputSystem;

public class Mover
{
    private InputAction _moveAction; // Movement Command
    private Rigidbody _rigidbody; // Rigidbody to move
    private readonly float _moveSpeed;
    
    private Vector2 _currentMoveInput = Vector2.zero;

    public Mover(InputAction moveAction, Rigidbody rigidbody, float moveSpeed)
    {
        _moveAction = moveAction;
        _rigidbody = rigidbody;
        _moveSpeed = moveSpeed;

        _moveAction.started += OnMoveAction;
        _moveAction.performed += OnMoveAction;
        _moveAction.canceled += OnMoveAction;
    }

    ~Mover()
    {
        _moveAction.started -= OnMoveAction;
        _moveAction.performed -= OnMoveAction;
        _moveAction.canceled -= OnMoveAction;
    }

    public void Tick()
    {
        var aux = _currentMoveInput * _moveSpeed;
        _rigidbody.velocity = new Vector3(aux.x, _rigidbody.velocity.y, aux.y);;
    }

    private void OnMoveAction(InputAction.CallbackContext context)
    {
        _currentMoveInput = context.ReadValue<Vector2>();
    }
}