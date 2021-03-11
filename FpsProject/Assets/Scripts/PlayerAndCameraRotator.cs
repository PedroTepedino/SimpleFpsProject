using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAndCameraRotator
{
    private Transform _player;
    private Transform _cameraFollow;

    private InputAction _action;

    private readonly float _maxVerticalAngle;
    private readonly float _cameraMoveSpeed;

    private Vector2 _currentMoveInput;

    public PlayerAndCameraRotator(InputAction action, Transform player, Transform cameraFollow, float maxVerticalAngle, float cameraMoveSpeed)
    {
        _player = player;
        _cameraFollow = cameraFollow;
        _action = action;
        _maxVerticalAngle = maxVerticalAngle;
        _cameraMoveSpeed = cameraMoveSpeed;

        _action.started += OnAction;
        _action.performed += OnAction;
        _action.canceled += OnAction;
    }

    ~PlayerAndCameraRotator()
    {
        _action.started -= OnAction;
        _action.performed -= OnAction;
        _action.canceled -= OnAction;
    }

    public void Tick(float deltaTime)
    {
        _player.Rotate(0, _currentMoveInput.x * _cameraMoveSpeed * deltaTime,0, Space.Self);

        _cameraFollow.Rotate(-_currentMoveInput.y * _cameraMoveSpeed * deltaTime,0,0,Space.Self );
        
        var currentAngle = _cameraFollow.rotation.eulerAngles.x;
        if (_cameraFollow.rotation.eulerAngles.x > 180)
            currentAngle -= 360f;
            
        if (currentAngle > _maxVerticalAngle / 2)
        {
            _cameraFollow.rotation = Quaternion.Euler(_maxVerticalAngle / 2,0, 0);
        }
        else if (currentAngle < -_maxVerticalAngle/2)
        {
            _cameraFollow.rotation = Quaternion.Euler(-_maxVerticalAngle / 2,0, 0);
        }
    }

    private void OnAction(InputAction.CallbackContext context)
    {
        _currentMoveInput = context.ReadValue<Vector2>();
    }
}