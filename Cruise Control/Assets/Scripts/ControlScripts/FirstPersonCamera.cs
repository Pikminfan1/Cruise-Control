using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    //public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    //public RotationAxes axes = RotationAxes.MouseXAndY;

    public float sensitivityX = 5f;
    public float sensitivityY = 5f;

    public float smoothing = 2f;

    public float minX = 0f;
    public float maxX = 360f;
    public float minY = 60f;
    public float maxY = 60f;

    float rotationX = -60f;
    float rotationY = 0f;

    //private List<float> rotArrayX = new List<float>();
    //float rotAverageX = 0f;

    //private List<float> rotArrayY = new List<float>();
    //float rotAverageY = 0f;

    //public float frameCount = 20;

    //Quaternion originalRotation;


    Vector2 look;
    Vector2 smoothV;

    GameObject character;
    void Update()
    {

        var md = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Debug.Log("Y axis" + md.y);
        md = Vector2.Scale(md, new Vector2(sensitivityX * smoothing, sensitivityY * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        look += smoothV;
        look.x = ClampAngle(look.x, minX, maxX);
        look.y = ClampAngle(look.y, minY, maxY);

        transform.localRotation = Quaternion.AngleAxis(-look.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(look.x, character.transform.up);


    }

    private void Start()
    {
        character = this.transform.parent.gameObject;
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
