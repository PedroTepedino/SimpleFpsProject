// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerControlls"",
            ""id"": ""8cac0794-e467-482a-9e4a-821f1f3855e9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""215c09ef-3390-4921-8b9e-7f4a5d606171"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b973562d-ec09-4cd0-bb7a-be113832b255"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5bc65b1d-7366-4628-8fa1-6d864799977c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""724b0a42-2af3-42f4-b701-7488c14bcce3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""b7071fba-508d-440e-ac62-cb453493e3ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""05195856-f67c-44b7-ab81-71b6b577ddd6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4eb2c53e-5fd7-4393-94e0-dc08d12902d9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7a94d10a-a357-4251-a533-906c0e4cf87c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""96366dec-557e-480c-9ec8-9e711a39c769"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""74794964-8ca3-4742-a582-4a8e289236ef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""343aa8f3-87b0-4d10-a508-cd5d926f0b6a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86e099b2-ff52-4060-906b-be659c6d78b1"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23780aba-690e-4a33-8bbc-79f6b62f0670"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e58ac9e8-fe3f-46e0-8e8a-6e574142214c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9afe113-b674-466a-b60f-23a165b4ca72"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""161a1d39-288d-48c7-8459-5e94efcd9d84"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d5afce9-6176-40f2-bd5b-2d9f064c3a38"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0671b55a-15be-4d64-b3d7-4e471d3d9ec7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5502b49c-c4b1-4c7f-a029-9af35d7e52a2"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuControlls"",
            ""id"": ""91f6e09f-d534-4c50-a348-6f0dec4a145a"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""04879346-4532-44dc-9563-7ea9226bb906"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7149256d-7b4d-46ec-8888-d24c4c1a5d79"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ae88e53-ab50-4a83-9fbc-8ee776a0c1ae"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControlls
        m_PlayerControlls = asset.FindActionMap("PlayerControlls", throwIfNotFound: true);
        m_PlayerControlls_Move = m_PlayerControlls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControlls_Look = m_PlayerControlls.FindAction("Look", throwIfNotFound: true);
        m_PlayerControlls_Jump = m_PlayerControlls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControlls_Shoot = m_PlayerControlls.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControlls_ChangeWeapon = m_PlayerControlls.FindAction("ChangeWeapon", throwIfNotFound: true);
        // MenuControlls
        m_MenuControlls = asset.FindActionMap("MenuControlls", throwIfNotFound: true);
        m_MenuControlls_Pause = m_MenuControlls.FindAction("Pause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerControlls
    private readonly InputActionMap m_PlayerControlls;
    private IPlayerControllsActions m_PlayerControllsActionsCallbackInterface;
    private readonly InputAction m_PlayerControlls_Move;
    private readonly InputAction m_PlayerControlls_Look;
    private readonly InputAction m_PlayerControlls_Jump;
    private readonly InputAction m_PlayerControlls_Shoot;
    private readonly InputAction m_PlayerControlls_ChangeWeapon;
    public struct PlayerControllsActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerControllsActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControlls_Move;
        public InputAction @Look => m_Wrapper.m_PlayerControlls_Look;
        public InputAction @Jump => m_Wrapper.m_PlayerControlls_Jump;
        public InputAction @Shoot => m_Wrapper.m_PlayerControlls_Shoot;
        public InputAction @ChangeWeapon => m_Wrapper.m_PlayerControlls_ChangeWeapon;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControlls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllsActions instance)
        {
            if (m_Wrapper.m_PlayerControllsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnShoot;
                @ChangeWeapon.started -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.performed -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.canceled -= m_Wrapper.m_PlayerControllsActionsCallbackInterface.OnChangeWeapon;
            }
            m_Wrapper.m_PlayerControllsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @ChangeWeapon.started += instance.OnChangeWeapon;
                @ChangeWeapon.performed += instance.OnChangeWeapon;
                @ChangeWeapon.canceled += instance.OnChangeWeapon;
            }
        }
    }
    public PlayerControllsActions @PlayerControlls => new PlayerControllsActions(this);

    // MenuControlls
    private readonly InputActionMap m_MenuControlls;
    private IMenuControllsActions m_MenuControllsActionsCallbackInterface;
    private readonly InputAction m_MenuControlls_Pause;
    public struct MenuControllsActions
    {
        private @PlayerInputs m_Wrapper;
        public MenuControllsActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_MenuControlls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_MenuControlls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControllsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControllsActions instance)
        {
            if (m_Wrapper.m_MenuControllsActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_MenuControllsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MenuControllsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MenuControllsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MenuControllsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MenuControllsActions @MenuControlls => new MenuControllsActions(this);
    public interface IPlayerControllsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
    }
    public interface IMenuControllsActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
