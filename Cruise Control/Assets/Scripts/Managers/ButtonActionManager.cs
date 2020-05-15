using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActionManager : MonoSingleton<ButtonActionManager> {
    public Controls controller;
    private static bool _northFaceButtonIsDown;
    /// <summary>
    /// Check if the North Face Button currently is pressed.
    /// </summary>
    public static bool NorthFaceButtonIsDown
    {
        get
        {
            return _northFaceButtonIsDown;
        }
    }
    private static bool _southFaceButtonIsDown;
    /// <summary>
    /// Check if the South Face Button currently is pressed.
    /// </summary>
    public static bool SouthFaceButtonIsDown
    {
        get
        {
            return _southFaceButtonIsDown;
        }
    }
    private static bool _westFaceButtonIsDown;
    /// <summary>
    /// Check if the West Face Button currently is pressed.
    /// </summary>
    public static bool WestFaceButtonIsDown
    {
        get
        {
            return _westFaceButtonIsDown;
        }
    }
    private static bool _eastFaceButtonIsDown;
    /// <summary>
    /// Check if the East Face Button currently is pressed.
    /// </summary>
    public static bool EastFaceButtonIsDown
    {
        get
        {
            return _eastFaceButtonIsDown;

        }
    }
    private static bool _leftTriggerIsDown;
    /// <summary>
    /// Check if the Left Trigger is being pressed at all
    /// </summary>
    public static bool LeftTriggerIsDown
    {
        get
        {
            return _leftTriggerIsDown;
        }
    }
    private static bool _rightTriggerIsDown;
    /// <summary>
    /// Check if the Right Trigger is being pressed at all
    /// </summary>
    public static bool RightTriggerIsDown
    {
        get
        {
            return _rightTriggerIsDown;
        }
    }

    private static float _leftTriggerValue;
    /// <summary>
    /// Returns the value of the Left Trigger as a float between 0.0 -> 1.0
    /// </summary>
    public static float LeftTriggerValue
    {
        get
        {
            return _leftTriggerValue;
        }
    }
    private static float _rightTriggerValue;
    /// <summary>
    /// Returns the value of the Right Trigger as a float between 0.0 -> 1.0
    /// </summary>
    public static float RightTriggerValue{
        get
        {

            return _rightTriggerValue;
        }
        }

    private static Vector2 _dpadDirection;

    /// <summary>
    /// Return a 2D vector of the current direction of the DPAD
    /// East and West are the X component, North and South are the Y component
    /// </summary>
    public static Vector2 DpadDirection
    {
        get
        {
            if(_dpadDirection == null)
            {
                return Vector2.zero;
            }
            return _dpadDirection;
        }
    }

    private static bool _selectButtonIsDown;
    /// <summary>
    /// Check if the select button currently is pressed. 
    /// </summary>
    public static bool SelectButtonIsDown
    {
        get
        {
            return _selectButtonIsDown;
        }
    }
    private static bool _startButtonIsDown;
    /// <summary>
    /// Check if the Start button currently is pressed.
    /// </summary>
    public static bool StartButtonIsDown
    {
        get
        {
            return _startButtonIsDown;
        }
    }
    private static bool _leftBumperIsDown;
    /// <summary>
    /// Check if the Left Bumper/Shoulder currently is pressed.
    /// </summary>
    public static bool LeftBumperIsDown
    {
        get
        {
            return _leftBumperIsDown;
        }
    }
    private static bool _rightBumperIsDown;
    /// <summary>
    /// Check if the Right Bymper/Shoulder currently is pressed.
    /// </summary>
    public static bool RightBumperIsDown
    {
        get
        {
            return _rightBumperIsDown;
        }
    }
    private static bool _leftStickIsDown;
    /// <summary>
    /// Check if the Left Joystick Button (L3) currently is pressed.
    /// </summary>
    public static bool LeftStickIsDown
    {
        get
        {
            return _leftStickIsDown;
        }
    }
    private static bool _rightStickIsDown;
    /// <summary>
    /// Check if the Right Joystick Button (R3) currently is pressed.
    /// </summary>
    public static bool RightStickIsDown
    {
        get
        {
            return _rightStickIsDown;
        }
    }
    
    private static Vector2 _leftStickDirection;
    /// <summary>
    /// Return a Vector2 of the Current direction of the left joystick. X Component is the horizontal and the Y component is the vertical.
    /// </summary>//
    public static Vector2 LeftStickDirection
    {
        get
        {
            if(_leftStickDirection == null)
            {
                return Vector2.zero;
            }
            return _leftStickDirection;
        }
    }
    private static Vector2 _rightStickDirection;
    /// <summary>
    /// Return a Vector2 of the Current direction of the Right joystick. X Component is the horizontal and the Y component is the vertical.
    /// </summary>
    public static Vector2 RightStickDirection
    {
        get
        {
            if(_rightStickDirection == null)
            {
                return Vector2.zero;
            }
            return _rightStickDirection;
        }
    }

    override
    public void Init()
    {
        controller = new Controls();
        //controller.BaseMovement.Move.performed += ctx => lookRaw = ctx.ReadValue<Vector2>();
        controller.BaseMovement.RightTrigger.performed += ctx => _rightTriggerValue = ctx.ReadValue<float>();
        controller.BaseMovement.RightTrigger.canceled += ctx => _rightTriggerValue = 0.0f;
        controller.BaseMovement.RightTrigger.performed += ctx => _rightTriggerIsDown = true;
        controller.BaseMovement.RightTrigger.canceled += ctx => _rightTriggerIsDown = false;

        controller.BaseMovement.LeftTrigger.performed += ctx => _leftTriggerValue = ctx.ReadValue<float>();
        controller.BaseMovement.LeftTrigger.canceled += ctx => _leftTriggerValue = 0.0f;
        controller.BaseMovement.LeftTrigger.performed += ctx => _leftTriggerIsDown = true;
        controller.BaseMovement.LeftTrigger.canceled += ctx => _leftTriggerIsDown = false;


        controller.BaseMovement.EastFaceButton.performed += ctx => _eastFaceButtonIsDown = true;
        controller.BaseMovement.EastFaceButton.canceled += ctx => _eastFaceButtonIsDown = false;   
        
        controller.BaseMovement.NorthFaceButton.performed += ctx => _northFaceButtonIsDown = true;
        controller.BaseMovement.NorthFaceButton.canceled += ctx => _northFaceButtonIsDown = false;   
        
        controller.BaseMovement.SouthFaceButton.performed += ctx => _southFaceButtonIsDown = true;
        controller.BaseMovement.SouthFaceButton.canceled += ctx => _southFaceButtonIsDown = false;

        controller.BaseMovement.WestFaceButton.performed += ctx => _westFaceButtonIsDown = true;
        controller.BaseMovement.WestFaceButton.canceled += ctx => _westFaceButtonIsDown = false;

        controller.BaseMovement.Dpad.performed += ctx => _dpadDirection = ctx.ReadValue<Vector2>();
        controller.BaseMovement.Dpad.canceled += ctx => _dpadDirection = Vector2.zero;

        controller.BaseMovement.LeftStickDirection.performed += ctx => _leftStickDirection = ctx.ReadValue<Vector2>();
        controller.BaseMovement.LeftStickDirection.canceled += ctx => _leftStickDirection = Vector2.zero;
        controller.BaseMovement.RightStickDirection.performed += ctx => _rightStickDirection = ctx.ReadValue<Vector2>();
        controller.BaseMovement.RightStickDirection.canceled += ctx => _rightStickDirection = Vector2.zero;

        controller.BaseMovement.LeftStickButton.performed += ctx => _leftStickIsDown = true;
        controller.BaseMovement.LeftStickButton.canceled += ctx => _leftStickIsDown = false;
        controller.BaseMovement.RightStickButton.performed += ctx => _rightStickIsDown = true;
        controller.BaseMovement.RightStickButton.canceled += ctx => _rightStickIsDown = false;

        controller.BaseMovement.SelectButton.performed += ctx => _selectButtonIsDown = true;
        controller.BaseMovement.SelectButton.canceled += ctx => _startButtonIsDown = false;

        controller.BaseMovement.StartButton.performed += ctx => _startButtonIsDown = true;
        controller.BaseMovement.StartButton.canceled += ctx => _startButtonIsDown = false;

        controller.BaseMovement.RightBumper.performed += ctx => _rightBumperIsDown = true;
        controller.BaseMovement.RightBumper.canceled += ctx => _rightBumperIsDown = false;

        controller.BaseMovement.LeftBumper.performed += ctx => _leftBumperIsDown = true;
        controller.BaseMovement.LeftBumper.canceled += ctx => _leftBumperIsDown = false;
        //controller.BaseMovement.ToggleWindow.performed += ctx => stats.isWindowRollToggle = true;
        //controller.BaseMovement.ToggleWindow.canceled += ctx => stats.isWindowRollToggle = false;
    }




    private void OnEnable()
    {
        controller.Enable();
    }
    private void OnDisable()
    {
        controller.Disable();
    }

}
