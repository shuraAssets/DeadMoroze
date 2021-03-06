// GENERATED AUTOMATICALLY FROM 'Assets/InputControllers/PlayerInput/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""6a57812e-49e6-47b6-bd4d-a8171b62c9b2"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""7093a5d5-e259-41da-98aa-bd69d77de9e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f6608da0-7160-4eaa-826a-1306f163a113"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OneWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""3ce1caec-d8cd-4574-8c7a-bde486a4a99f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TwoWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""41ea5af6-bad8-4120-910f-5af1fb631dd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""3b8beff4-2ad4-4aab-af12-1693329f4137"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""977d7e82-0347-4770-8642-9aa4093b0916"",
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
                    ""id"": ""746b4657-80d8-44b6-bea0-3999ecfd183e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboards"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fac5641b-cd33-4a9b-915d-57fa621eafd1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboards"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""028ae6de-cf02-4a52-b801-5847f0f484ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboards"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""14c36ebf-548d-4479-810a-d012345bc2fa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboards"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""393ad2a3-c2cd-4e24-b9a0-bb04758efc78"",
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
                    ""id"": ""417b13f4-076b-480d-9f5a-9fbef8acc6de"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e485f8d4-aa74-4f52-a84b-2f8a80b30bbc"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91a361e8-8db3-4422-ae1d-18757ccb4cee"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""55e789f4-4503-4553-bc63-300416d274bb"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ee4d8b65-56d2-4096-aa75-0cc373c136be"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboards"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed885da8-01c6-44b3-9a76-0d99d6f7b9fe"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""634c7fcf-f8bb-4d95-bae7-812d3de60793"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboards"",
                    ""action"": ""OneWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7d1ab54-d392-4947-95c5-278a973364b8"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and keyboards"",
                    ""action"": ""TwoWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f843c805-cb8d-4315-b471-d4c85a86bf24"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and keyboards"",
            ""bindingGroup"": ""Mouse and keyboards"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Move = m_PlayerActions.FindAction("Move", throwIfNotFound: true);
        m_PlayerActions_Shoot = m_PlayerActions.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerActions_OneWeapon = m_PlayerActions.FindAction("OneWeapon", throwIfNotFound: true);
        m_PlayerActions_TwoWeapon = m_PlayerActions.FindAction("TwoWeapon", throwIfNotFound: true);
        m_PlayerActions_ChangeWeapon = m_PlayerActions.FindAction("ChangeWeapon", throwIfNotFound: true);
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

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Move;
    private readonly InputAction m_PlayerActions_Shoot;
    private readonly InputAction m_PlayerActions_OneWeapon;
    private readonly InputAction m_PlayerActions_TwoWeapon;
    private readonly InputAction m_PlayerActions_ChangeWeapon;
    public struct PlayerActionsActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActionsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerActions_Move;
        public InputAction @Shoot => m_Wrapper.m_PlayerActions_Shoot;
        public InputAction @OneWeapon => m_Wrapper.m_PlayerActions_OneWeapon;
        public InputAction @TwoWeapon => m_Wrapper.m_PlayerActions_TwoWeapon;
        public InputAction @ChangeWeapon => m_Wrapper.m_PlayerActions_ChangeWeapon;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnShoot;
                @OneWeapon.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnOneWeapon;
                @OneWeapon.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnOneWeapon;
                @OneWeapon.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnOneWeapon;
                @TwoWeapon.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnTwoWeapon;
                @TwoWeapon.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnTwoWeapon;
                @TwoWeapon.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnTwoWeapon;
                @ChangeWeapon.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnChangeWeapon;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @OneWeapon.started += instance.OnOneWeapon;
                @OneWeapon.performed += instance.OnOneWeapon;
                @OneWeapon.canceled += instance.OnOneWeapon;
                @TwoWeapon.started += instance.OnTwoWeapon;
                @TwoWeapon.performed += instance.OnTwoWeapon;
                @TwoWeapon.canceled += instance.OnTwoWeapon;
                @ChangeWeapon.started += instance.OnChangeWeapon;
                @ChangeWeapon.performed += instance.OnChangeWeapon;
                @ChangeWeapon.canceled += instance.OnChangeWeapon;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    private int m_MouseandkeyboardsSchemeIndex = -1;
    public InputControlScheme MouseandkeyboardsScheme
    {
        get
        {
            if (m_MouseandkeyboardsSchemeIndex == -1) m_MouseandkeyboardsSchemeIndex = asset.FindControlSchemeIndex("Mouse and keyboards");
            return asset.controlSchemes[m_MouseandkeyboardsSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActionsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnOneWeapon(InputAction.CallbackContext context);
        void OnTwoWeapon(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
    }
}
