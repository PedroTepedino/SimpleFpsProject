using UnityEngine;
using UnityEngine.InputSystem;

public class Jumper
{
    private InputAction _jumpAction; // Movement Command
    private Rigidbody _rigidbody; // Rigidbody to Jump
    private readonly float _jumpSpeed;
    private readonly Grounder _grounder;

    public Jumper(InputAction jumpAction, Rigidbody rigidbody, float jumpSpeed, Grounder grounder)
    {
        _jumpAction = jumpAction;
        _rigidbody = rigidbody;
        _jumpSpeed = jumpSpeed;
        _grounder = grounder;

        _jumpAction.started += OnJumpAction;
    }

    ~Jumper()
    {
        _jumpAction.started -= OnJumpAction;
    }
    

    private void OnJumpAction(InputAction.CallbackContext context)
    {
        if (!_grounder.IsGrounded) return;
        
        var newVelocity = _rigidbody.velocity;
        newVelocity.y = _jumpSpeed;
        
        _rigidbody.velocity = newVelocity;
    }
}