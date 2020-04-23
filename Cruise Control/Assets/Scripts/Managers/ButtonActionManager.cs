using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActionManager : MonoSingleton<ButtonActionManager> {
    public Controls controller;
    private static bool _northFaceButtonIsDown;
    public static bool NorthFaceButtonIsDown
    {
        get
        {
            return _northFaceButtonIsDown;
        }
    }
    private static bool _southFaceButtonIsDown;
    public static bool SouthFaceButtonIsDown
    {
        get
        {
            return _southFaceButtonIsDown;
        }
    }
    private static bool _westFaceButtonIsDown;
    public static bool WestFaceButtonIsDown
    {
        get
        {
            return _westFaceButtonIsDown;
        }
    }
    private static bool _eastFaceButtonIsDown;
    public static bool EastFaceButtonIsDown
    {
        get
        {
            return _eastFaceButtonIsDown;

        }
    }
    private static float _leftTriggerValue;
    private static float _rightTriggerValue;

    public static float LeftTriggerValue
    {
        get
        {
            return _leftTriggerValue;
        }
    }
    public static float RightTriggerValue{
        get
        {

            return _rightTriggerValue;
        }
        }
    public bool isPress;

    override
    public void Init()
    {
        controller = new Controls();
        //controller.BaseMovement.Move.performed += ctx => lookRaw = ctx.ReadValue<Vector2>();
        controller.BaseMovement.RightTrigger.performed += ctx => _rightTriggerValue = ctx.ReadValue<float>();
        controller.BaseMovement.RightTrigger.performed += ctx => isPress = true;
        controller.BaseMovement.RightTrigger.canceled += ctx => isPress = false;

        controller.BaseMovement.EastFaceButton.performed += ctx => _eastFaceButtonIsDown = true;
        controller.BaseMovement.EastFaceButton.canceled += ctx => _eastFaceButtonIsDown = false;   
        
        controller.BaseMovement.NorthFaceButton.performed += ctx => _northFaceButtonIsDown = true;
        controller.BaseMovement.NorthFaceButton.canceled += ctx => _northFaceButtonIsDown = false;   
        
        controller.BaseMovement.SouthFaceButton.performed += ctx => _southFaceButtonIsDown = true;
        controller.BaseMovement.SouthFaceButton.canceled += ctx => _southFaceButtonIsDown = false;

        controller.BaseMovement.WestFaceButton.performed += ctx => _westFaceButtonIsDown = true;
        controller.BaseMovement.WestFaceButton.canceled += ctx => _westFaceButtonIsDown = false;
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
