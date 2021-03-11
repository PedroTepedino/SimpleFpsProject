using Unity.XR.OpenVR;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Since its a single instance player, might as well be a singleton.
    public static Player Instance { get; private set; }
    
    [SerializeField] private float _movementSpeed = 10f;
    [SerializeField] private float _jumpSpeed = 2f;
    [SerializeField] private float _maxVerticalLookAngle = 120f;
    [SerializeField] private float _cameraLookSpeed = 10f;
    
    private PlayerInputs _playerInputs;
    
    // GameObject Components 
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Grounder _grounder;
    [SerializeField] private Transform _cameraFollowTransform;

    // Components
    private Mover _mover;
    private Jumper _jumper;
    private PlayerAndCameraRotator _cameraRotator;

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
        _jumper = new Jumper(_playerInputs.PlayerControlls.Jump, _rigidbody, _jumpSpeed, _grounder);
        _cameraRotator = new PlayerAndCameraRotator(_playerInputs.PlayerControlls.Look, this.transform,
            _cameraFollowTransform, _maxVerticalLookAngle, _cameraLookSpeed);

    }

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;

        _playerInputs.PlayerControlls.Enable();
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;

        _playerInputs.PlayerControlls.Disable();
    }

    private void Update()
    {
        _mover.Tick();
        _cameraRotator.Tick(Time.deltaTime);
    }

    private void OnValidate()
    {
        if (_rigidbody == null)
        {
            _rigidbody = this.GetComponent<Rigidbody>();
        }

        if (_grounder == null)
        {
            _grounder = this.GetComponentInChildren<Grounder>();
        }
    } 
}