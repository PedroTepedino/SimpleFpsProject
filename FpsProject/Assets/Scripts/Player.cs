using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.HID;

public class Player : MonoBehaviour
{
    // Since its a single instance player, might as well be a singleton.
    public static Player Instance { get; private set; }
    
    [SerializeField] private float _movementSpeed = 10f;
    [SerializeField] private float _jumpSpeed = 2f;

    private PlayerInputs _playerInputs;
    
    // GameObject Components 
    private Rigidbody _rigidbody;

    // Components
    private Mover _mover;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);

        _playerInputs = new PlayerInputs();
        _mover = new Mover(_playerInputs.PlayerControlls.Move, _rigidbody, _movementSpeed);
    }

    private void OnEnable()
    {
        _playerInputs.PlayerControlls.Enable();
    }

    private void OnDisable()
    {
        _playerInputs.PlayerControlls.Disable();
    }

    private void Update()
    {
        _mover.Tick();
    }


    private void OnValidate()
    {
        if (_rigidbody == null)
        {
            _rigidbody = this.GetComponent<Rigidbody>();
        }
    } 
}

public class Mover
{
    private InputAction _moveAction; // Movement Command
    private Rigidbody _rigidbody; // Rigidbody to move
    private readonly float _moveSpeed;
    
    private Vector3 _currentMoveInput = Vector3.zero;

    public Mover(InputAction moveAction, Rigidbody rigidbody, float moveSpeed)
    {
        _moveAction = moveAction;
        _rigidbody = rigidbody;
        _moveSpeed = moveSpeed;

        _moveAction.started += OnMoveAction;
        _moveAction.performed += OnMoveAction;
        _moveAction.canceled += OnMoveAction;
    }
    
    public void Tick()
    {
        _rigidbody.velocity = _currentMoveInput * _moveSpeed;
    }

    private void OnMoveAction(InputAction.CallbackContext callbackContext)
    {
        var aux = callbackContext.ReadValue<Vector2>();
        _currentMoveInput = new Vector3(aux.x, _rigidbody.velocity.y, aux.y);
    }
}

public class Jumper
{
    
}