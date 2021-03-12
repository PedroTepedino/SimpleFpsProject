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
        var transform = _rigidbody.transform;
        var newVelocity = (transform.forward * _currentMoveInput.y) +
                          (transform.right * _currentMoveInput.x);
        newVelocity = newVelocity.normalized * _moveSpeed;
        newVelocity.y = _rigidbody.velocity.y;

        _rigidbody.velocity = newVelocity;
    }

    private void OnMoveAction(InputAction.CallbackContext context)
    {
        _currentMoveInput = context.ReadValue<Vector2>();
    }
}