using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    GameObject heldObject;
    Transform prevParent;
    bool isHolding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitRay;
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.green); ;
        if(ButtonActionManager.WestFaceButtonIsDown && isHolding)
        {

        }
        bool isHit = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out hitRay);
        if (isHit)
        {
            if (hitRay.collider.gameObject.tag.Equals("Grabbable") && ButtonActionManager.SouthFaceButtonIsDown){
                prevParent = hitRay.collider.gameObject.transform.parent;
                heldObject = hitRay.collider.gameObject;
                hitRay.collider.gameObject.transform.parent = Camera.main.transform;
            }
        }
        else
        {
            Debug.Log("NOPE");
        }
    }
}
