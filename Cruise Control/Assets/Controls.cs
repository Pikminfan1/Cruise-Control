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
                    ""name"": ""LeftStick"",
                    ""id"": ""937d6410-9d14-4926-a110-5e8dee36eea3"",
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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Base Movement
        m_BaseMovement = asset.FindActionMap("Base Movement", throwIfNotFound: true);
        m_BaseMovement_Move = m_BaseMovement.FindAction("Move", throwIfNotFound: true);
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
    public struct BaseMovementActions
    {
        private @Controls m_Wrapper;
        public BaseMovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BaseMovement_Move;
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
            }
            m_Wrapper.m_BaseMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public BaseMovementActions @BaseMovement => new BaseMovementActions(this);
    public interface IBaseMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
