// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Base Movement"",
            ""id"": ""cd3347e4-09bf-40ba-b3be-63f0bc724dda"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e32f2183-1744-4ad8-8c2f-db834f982eb4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleWindow"",
                    ""type"": ""Button"",
                    ""id"": ""0cf33fed-90c7-4c0f-8d8a-9a063bab4e29"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateWindow"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b0841fc-b31b-4cc9-98ba-87cf8404f972"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IncreaseCruise"",
                    ""type"": ""Button"",
                    ""id"": ""8baad314-d4ee-410e-9503-daa890814c23"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnOffCruise"",
                    ""type"": ""Button"",
                    ""id"": ""934fe230-a75d-4d5e-a652-bf97ff02cb5a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2b72ea86-2809-481c-9b77-a5c887ec7c07"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""4065f274-d259-4aa1-9750-96d53e4d6670"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""316fa259-3292-4964-97e7-43321e02adf3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""East Face Button"",
                    ""type"": ""Button"",
                    ""id"": ""5148f7ea-e049-4ad0-9786-f45526c6ce91"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West Face Button"",
                    ""type"": ""Button"",
                    ""id"": ""55d3a429-4874-4fb2-bb7c-745d17bb3ecc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""North Face Button"",
                    ""type"": ""Button"",
                    ""id"": ""5cb8429a-4325-4ea7-bec8-2f6cd1ef4147"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""South Face Button"",
                    ""type"": ""Button"",
                    ""id"": ""5cdd751b-8ec2-4c07-b0c7-0f8d3970fef8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6b874681-c41f-4863-8876-c7149d9bbdcb"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""rightStick"",
                    ""id"": ""937d6410-9d14-4926-a110-5e8dee36eea3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""91bc2f5a-fbcd-46a7-9f88-6bbd337272d1"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3dbb4cf6-7f78-44f1-99af-51d4452f90f8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e1bf7a5b-e492-477e-9c47-8db09141edaa"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9146179d-d981-46c7-996e-5f1fbea63807"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4e66d0fd-f57d-4bb2-98e4-09ec097dd70c"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleWindow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6788cdbd-b484-4380-a23d-5581e5ca689a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateWindow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""464ce1f5-30c7-47b2-9c03-082f1d249023"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseCruise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebee8024-889e-4ac6-a4c0-aac5fe78dbd0"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnOffCruise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""addbfad3-7822-4fe9-a9f9-916340aec257"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""2d5eb65f-0ac0-425c-af06-fa6c3c51480a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""a72608a0-7ff4-4b4a-a186-de68a786a641"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""ed84b5bc-a2a2-4dee-b5cc-badb62745dad"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""d7f83cb9-d038-4ef2-a15f-feb63efbdb06"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e6ebbf94-e388-48f9-b3ad-d28d3d6fc2a5"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6e3affd-90ad-437b-acc8-c52a0f8c56b8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e1bbfe0-60c8-486d-8ba2-3db07ba182f2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East Face Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb6f5ed6-4d56-41e1-84ce-09eb19b17cab"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West Face Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""277b1098-f883-4941-afcb-0994a0800bbf"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North Face Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05e9a7ff-4648-467a-9dab-05333a395729"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South Face Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Base Movement
        m_BaseMovement = asset.FindActionMap("Base Movement", throwIfNotFound: true);
        m_BaseMovement_Move = m_BaseMovement.FindAction("Move", throwIfNotFound: true);
        m_BaseMovement_ToggleWindow = m_BaseMovement.FindAction("ToggleWindow", throwIfNotFound: true);
        m_BaseMovement_RotateWindow = m_BaseMovement.FindAction("RotateWindow", throwIfNotFound: true);
        m_BaseMovement_IncreaseCruise = m_BaseMovement.FindAction("IncreaseCruise", throwIfNotFound: true);
        m_BaseMovement_TurnOffCruise = m_BaseMovement.FindAction("TurnOffCruise", throwIfNotFound: true);
        m_BaseMovement_Steer = m_BaseMovement.FindAction("Steer", throwIfNotFound: true);
        m_BaseMovement_RightTrigger = m_BaseMovement.FindAction("Right Trigger", throwIfNotFound: true);
        m_BaseMovement_LeftTrigger = m_BaseMovement.FindAction("Left Trigger", throwIfNotFound: true);
        m_BaseMovement_EastFaceButton = m_BaseMovement.FindAction("East Face Button", throwIfNotFound: true);
        m_BaseMovement_WestFaceButton = m_BaseMovement.FindAction("West Face Button", throwIfNotFound: true);
        m_BaseMovement_NorthFaceButton = m_BaseMovement.FindAction("North Face Button", throwIfNotFound: true);
        m_BaseMovement_SouthFaceButton = m_BaseMovement.FindAction("South Face Button", throwIfNotFound: true);
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

    // Base Movement
    private readonly InputActionMap m_BaseMovement;
    private IBaseMovementActions m_BaseMovementActionsCallbackInterface;
    private readonly InputAction m_BaseMovement_Move;
    private readonly InputAction m_BaseMovement_ToggleWindow;
    private readonly InputAction m_BaseMovement_RotateWindow;
    private readonly InputAction m_BaseMovement_IncreaseCruise;
    private readonly InputAction m_BaseMovement_TurnOffCruise;
    private readonly InputAction m_BaseMovement_Steer;
    private readonly InputAction m_BaseMovement_RightTrigger;
    private readonly InputAction m_BaseMovement_LeftTrigger;
    private readonly InputAction m_BaseMovement_EastFaceButton;
    private readonly InputAction m_BaseMovement_WestFaceButton;
    private readonly InputAction m_BaseMovement_NorthFaceButton;
    private readonly InputAction m_BaseMovement_SouthFaceButton;
    public struct BaseMovementActions
    {
        private @Controls m_Wrapper;
        public BaseMovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BaseMovement_Move;
        public InputAction @ToggleWindow => m_Wrapper.m_BaseMovement_ToggleWindow;
        public InputAction @RotateWindow => m_Wrapper.m_BaseMovement_RotateWindow;
        public InputAction @IncreaseCruise => m_Wrapper.m_BaseMovement_IncreaseCruise;
        public InputAction @TurnOffCruise => m_Wrapper.m_BaseMovement_TurnOffCruise;
        public InputAction @Steer => m_Wrapper.m_BaseMovement_Steer;
        public InputAction @RightTrigger => m_Wrapper.m_BaseMovement_RightTrigger;
        public InputAction @LeftTrigger => m_Wrapper.m_BaseMovement_LeftTrigger;
        public InputAction @EastFaceButton => m_Wrapper.m_BaseMovement_EastFaceButton;
        public InputAction @WestFaceButton => m_Wrapper.m_BaseMovement_WestFaceButton;
        public InputAction @NorthFaceButton => m_Wrapper.m_BaseMovement_NorthFaceButton;
        public InputAction @SouthFaceButton => m_Wrapper.m_BaseMovement_SouthFaceButton;
        public InputActionMap Get() { return m_Wrapper.m_BaseMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseMovementActions set) { return set.Get(); }
        public void SetCallbacks(IBaseMovementActions instance)
        {
            if (m_Wrapper.m_BaseMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMove;
                @ToggleWindow.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnToggleWindow;
                @ToggleWindow.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnToggleWindow;
                @ToggleWindow.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnToggleWindow;
                @RotateWindow.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnRotateWindow;
                @RotateWindow.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnRotateWindow;
                @RotateWindow.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnRotateWindow;
                @IncreaseCruise.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnIncreaseCruise;
                @IncreaseCruise.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnIncreaseCruise;
                @IncreaseCruise.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnIncreaseCruise;
                @TurnOffCruise.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnTurnOffCruise;
                @TurnOffCruise.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnTurnOffCruise;
                @TurnOffCruise.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnTurnOffCruise;
                @Steer.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnSteer;
                @RightTrigger.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnRightTrigger;
                @LeftTrigger.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnLeftTrigger;
                @EastFaceButton.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnEastFaceButton;
                @EastFaceButton.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnEastFaceButton;
                @EastFaceButton.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnEastFaceButton;
                @WestFaceButton.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnWestFaceButton;
                @WestFaceButton.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnWestFaceButton;
                @WestFaceButton.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnWestFaceButton;
                @NorthFaceButton.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnNorthFaceButton;
                @NorthFaceButton.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnNorthFaceButton;
                @NorthFaceButton.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnNorthFaceButton;
                @SouthFaceButton.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnSouthFaceButton;
                @SouthFaceButton.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnSouthFaceButton;
                @SouthFaceButton.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnSouthFaceButton;
            }
            m_Wrapper.m_BaseMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ToggleWindow.started += instance.OnToggleWindow;
                @ToggleWindow.performed += instance.OnToggleWindow;
                @ToggleWindow.canceled += instance.OnToggleWindow;
                @RotateWindow.started += instance.OnRotateWindow;
                @RotateWindow.performed += instance.OnRotateWindow;
                @RotateWindow.canceled += instance.OnRotateWindow;
                @IncreaseCruise.started += instance.OnIncreaseCruise;
                @IncreaseCruise.performed += instance.OnIncreaseCruise;
                @IncreaseCruise.canceled += instance.OnIncreaseCruise;
                @TurnOffCruise.started += instance.OnTurnOffCruise;
                @TurnOffCruise.performed += instance.OnTurnOffCruise;
                @TurnOffCruise.canceled += instance.OnTurnOffCruise;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @RightTrigger.started += instance.OnRightTrigger;
                @RightTrigger.performed += instance.OnRightTrigger;
                @RightTrigger.canceled += instance.OnRightTrigger;
                @LeftTrigger.started += instance.OnLeftTrigger;
                @LeftTrigger.performed += instance.OnLeftTrigger;
                @LeftTrigger.canceled += instance.OnLeftTrigger;
                @EastFaceButton.started += instance.OnEastFaceButton;
                @EastFaceButton.performed += instance.OnEastFaceButton;
                @EastFaceButton.canceled += instance.OnEastFaceButton;
                @WestFaceButton.started += instance.OnWestFaceButton;
                @WestFaceButton.performed += instance.OnWestFaceButton;
                @WestFaceButton.canceled += instance.OnWestFaceButton;
                @NorthFaceButton.started += instance.OnNorthFaceButton;
                @NorthFaceButton.performed += instance.OnNorthFaceButton;
                @NorthFaceButton.canceled += instance.OnNorthFaceButton;
                @SouthFaceButton.started += instance.OnSouthFaceButton;
                @SouthFaceButton.performed += instance.OnSouthFaceButton;
                @SouthFaceButton.canceled += instance.OnSouthFaceButton;
            }
        }
    }
    public BaseMovementActions @BaseMovement => new BaseMovementActions(this);
    public interface IBaseMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnToggleWindow(InputAction.CallbackContext context);
        void OnRotateWindow(InputAction.CallbackContext context);
        void OnIncreaseCruise(InputAction.CallbackContext context);
        void OnTurnOffCruise(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnEastFaceButton(InputAction.CallbackContext context);
        void OnWestFaceButton(InputAction.CallbackContext context);
        void OnNorthFaceButton(InputAction.CallbackContext context);
        void OnSouthFaceButton(InputAction.CallbackContext context);
    }
}
