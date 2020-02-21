using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controller used for in-cabin first person camera movement
public class FirstPersonCamera : MonoBehaviour
{

    //Values for Camera Sensitivity for x and Y axis
    public float sensitivityX = 5f;
    public float sensitivityY = 5f;

    public float smoothing = 2f;

    //Floats used to Clamp view
    public float minX = 0f;
    public float maxX = 360f;
    public float minY = 0;
    public float maxY = 360;

    //Raw Vector From Right Joystick
    Vector2 lookRaw;
    //Used to determine if player is in "look" state or "roll window" state
    bool rStickButton;
    //Used to acumulate smoothed increment for the cameras rotation
    Vector2 lookSmooth;
    //Used To calculate Smooth value
    Vector2 smoothV;
    //Scriptable Object that holds values other scripts may also need access too
    public PlayerStats stats;

    //Holds reference to parent object so x rotation doesnt affect the y rotation
    GameObject character;
    //Used for new input manager
    Controls controllerTest;
    void FixedUpdate()
    {
        //This used the Legacy input system
        //var md = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        var md = lookRaw;

        //If the right stick is not pushed in,
        if (!rStickButton)
        {
            //Retrieve the raw vector and scale it using our smooths and sensitivity values
            md = Vector2.Scale(md, new Vector2(sensitivityX * smoothing, sensitivityY * smoothing));
            smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
            smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
            //Calculate the new rotation vectors before applying the apporpriate rotation
            lookSmooth += smoothV;
            lookSmooth.x = ClampAngle(lookSmooth.x, minX, maxX);
            lookSmooth.y = ClampAngle(lookSmooth.y, minY, maxY);

            //Preform a local rotation on the camera for y and the parent for x
            transform.localRotation = Quaternion.AngleAxis(-lookSmooth.y, Vector3.right);
            character.transform.localRotation = Quaternion.AngleAxis(lookSmooth.x, character.transform.up);
          
        }

    }

    private void Start()
    {
        //character = this.transform.parent.gameObject;
    }
    //Awake is used to setup callbacks for Input and grab the parent object
    private void Awake()
    {
        controllerTest = new Controls();
        controllerTest.BaseMovement.Move.performed += ctx => lookRaw = ctx.ReadValue<Vector2>();
        controllerTest.BaseMovement.ToggleWindow.performed += ctx => stats.isWindowRollToggle = true;
        controllerTest.BaseMovement.ToggleWindow.canceled += ctx => stats.isWindowRollToggle = false;

        character = this.transform.parent.gameObject;
    }

    //Enable/Disable used to turn on/off Player input
    private void OnEnable()
    {
        controllerTest.Enable();
    }
    private void OnDisable()
    {
        controllerTest.Disable();
    }

    //This method takes a given angle and ensures it falls between -360 and 360
    //And between the given min and max values
    public static float ClampAngle(float angle, float min, float max)
    {
        angle = angle % 360;
        if((angle >= -360f) && (angle <= 360f))
        {
            if (angle < -360f){
                angle += 360f;
            }
            if(angle > 360f)
            {
                angle -= 360f;
            }
        }
        return Mathf.Clamp(angle, min, max);
    }
}
