// GENERATED AUTOMATICALLY FROM 'Assets/ProjectStuff/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c6505759-4953-48af-acb0-8dffe78a4b5c"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""PassThrough"",
                    ""id"": ""06b2bde6-66ab-479a-9e80-493c5e55eccc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Strafe"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8ea6239c-6634-4fb2-8e88-f62b94ca8429"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5262713d-7901-4278-a00f-48fc06d5b143"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""71789795-3a66-41d7-bd6a-518577442ede"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PitchYaw"",
                    ""type"": ""PassThrough"",
                    ""id"": ""83cd8c00-2bdd-437b-bdbf-251e6c073cf7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""864487ea-3920-4af8-99f6-58f534892715"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ThrustKB"",
                    ""id"": ""e6fc4f08-4068-4412-948c-96111229ae7f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d3814a67-6706-4f79-bfdb-d6db411d6274"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5c90f98e-41c3-4083-a6d3-5225fc24fbfc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""StrafeKB"",
                    ""id"": ""7780e565-34b4-4117-89a8-a561babdfd44"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""55883f87-7567-4925-9abf-8a93e89c665b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""aea0a372-b303-4aa8-8ed6-457f99fc8437"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UpDownKB"",
                    ""id"": ""d77267c0-74f3-4d79-b058-8bdc3ef53e23"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3af6a2d2-3ef0-49e7-90cd-732045d68e67"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c6f2073c-67b5-44c0-985f-4321513216a9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RollKB"",
                    ""id"": ""900c9488-4248-42fb-8f0c-3a28fa4122e0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b4028aac-4e7f-43b1-adf0-e4f32f527c9b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""493f53f9-b53f-4f93-901a-38ad86066c14"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""267f33f6-86b3-4a98-a292-4b257f5d6e68"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PitchYaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7250ab2f-0219-4d27-b75d-ef97a87410ff"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Thrust = m_Player.FindAction("Thrust", throwIfNotFound: true);
        m_Player_Strafe = m_Player.FindAction("Strafe", throwIfNotFound: true);
        m_Player_UpDown = m_Player.FindAction("UpDown", throwIfNotFound: true);
        m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
        m_Player_PitchYaw = m_Player.FindAction("PitchYaw", throwIfNotFound: true);
        m_Player_Boost = m_Player.FindAction("Boost", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Thrust;
    private readonly InputAction m_Player_Strafe;
    private readonly InputAction m_Player_UpDown;
    private readonly InputAction m_Player_Roll;
    private readonly InputAction m_Player_PitchYaw;
    private readonly InputAction m_Player_Boost;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_Player_Thrust;
        public InputAction @Strafe => m_Wrapper.m_Player_Strafe;
        public InputAction @UpDown => m_Wrapper.m_Player_UpDown;
        public InputAction @Roll => m_Wrapper.m_Player_Roll;
        public InputAction @PitchYaw => m_Wrapper.m_Player_PitchYaw;
        public InputAction @Boost => m_Wrapper.m_Player_Boost;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrust;
                @Strafe.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafe;
                @Strafe.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafe;
                @Strafe.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrafe;
                @UpDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @Roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @PitchYaw.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchYaw;
                @PitchYaw.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchYaw;
                @PitchYaw.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchYaw;
                @Boost.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBoost;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Strafe.started += instance.OnStrafe;
                @Strafe.performed += instance.OnStrafe;
                @Strafe.canceled += instance.OnStrafe;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @PitchYaw.started += instance.OnPitchYaw;
                @PitchYaw.performed += instance.OnPitchYaw;
                @PitchYaw.canceled += instance.OnPitchYaw;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnPitchYaw(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
    }
}
