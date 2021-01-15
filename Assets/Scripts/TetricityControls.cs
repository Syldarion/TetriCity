// GENERATED AUTOMATICALLY FROM 'Assets/TetricityControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TetricityControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TetricityControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TetricityControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e1867aeb-415e-4134-b743-9951cbf9b98f"",
            ""actions"": [
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""41d3b1e2-b3a8-42e7-bd66-7915f52f2577"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""TiltCamera"",
                    ""type"": ""Value"",
                    ""id"": ""264af6ad-52c9-40a6-aefd-b401c1cac866"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""Value"",
                    ""id"": ""f69712d3-b68d-4107-a5f0-61ff75ab4065"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""PlacePiece"",
                    ""type"": ""Button"",
                    ""id"": ""27ea05ee-1f67-4419-af9e-459cdab6a142"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotatePiece"",
                    ""type"": ""Button"",
                    ""id"": ""2674615d-5607-4358-9470-eb20e6f90ab2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""70c72cd9-306f-4471-a22f-8c2015296d24"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2a9a9b3c-bfc5-465c-8dde-583fcd83113f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9f1f07ce-5eac-42cd-b2f0-d6b454dd8256"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bc9dd7cb-5da7-4b86-8fcd-ac4089abdfe2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""16daf59c-259a-43ed-adbc-696a7dab3073"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4fb74316-5f3f-402b-888e-1c558f31a467"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""19d2e5d0-672a-40a9-8d5b-8563f0617e6b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5404a2e9-0499-434e-a3bb-be0e60702f8c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""917a40be-52c6-4fdf-a459-afb9de17ea8e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TiltCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""49290176-b267-414e-9854-67a05a726683"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""TiltCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9b01ea74-a46a-421a-942e-f674ce28d510"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""TiltCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""789e4f8a-e11d-4f7a-8bc8-a0a2a3b455d2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""PlacePiece"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4ab6df4-5d68-45bf-a34e-46fc7843cafa"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""RotatePiece"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_RotateCamera = m_Player.FindAction("RotateCamera", throwIfNotFound: true);
        m_Player_TiltCamera = m_Player.FindAction("TiltCamera", throwIfNotFound: true);
        m_Player_MoveCamera = m_Player.FindAction("MoveCamera", throwIfNotFound: true);
        m_Player_PlacePiece = m_Player.FindAction("PlacePiece", throwIfNotFound: true);
        m_Player_RotatePiece = m_Player.FindAction("RotatePiece", throwIfNotFound: true);
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
    private readonly InputAction m_Player_RotateCamera;
    private readonly InputAction m_Player_TiltCamera;
    private readonly InputAction m_Player_MoveCamera;
    private readonly InputAction m_Player_PlacePiece;
    private readonly InputAction m_Player_RotatePiece;
    public struct PlayerActions
    {
        private @TetricityControls m_Wrapper;
        public PlayerActions(@TetricityControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateCamera => m_Wrapper.m_Player_RotateCamera;
        public InputAction @TiltCamera => m_Wrapper.m_Player_TiltCamera;
        public InputAction @MoveCamera => m_Wrapper.m_Player_MoveCamera;
        public InputAction @PlacePiece => m_Wrapper.m_Player_PlacePiece;
        public InputAction @RotatePiece => m_Wrapper.m_Player_RotatePiece;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @RotateCamera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateCamera;
                @TiltCamera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltCamera;
                @TiltCamera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltCamera;
                @TiltCamera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltCamera;
                @MoveCamera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveCamera;
                @PlacePiece.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlacePiece;
                @PlacePiece.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlacePiece;
                @PlacePiece.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlacePiece;
                @RotatePiece.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotatePiece;
                @RotatePiece.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotatePiece;
                @RotatePiece.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotatePiece;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
                @TiltCamera.started += instance.OnTiltCamera;
                @TiltCamera.performed += instance.OnTiltCamera;
                @TiltCamera.canceled += instance.OnTiltCamera;
                @MoveCamera.started += instance.OnMoveCamera;
                @MoveCamera.performed += instance.OnMoveCamera;
                @MoveCamera.canceled += instance.OnMoveCamera;
                @PlacePiece.started += instance.OnPlacePiece;
                @PlacePiece.performed += instance.OnPlacePiece;
                @PlacePiece.canceled += instance.OnPlacePiece;
                @RotatePiece.started += instance.OnRotatePiece;
                @RotatePiece.performed += instance.OnRotatePiece;
                @RotatePiece.canceled += instance.OnRotatePiece;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnTiltCamera(InputAction.CallbackContext context);
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnPlacePiece(InputAction.CallbackContext context);
        void OnRotatePiece(InputAction.CallbackContext context);
    }
}
