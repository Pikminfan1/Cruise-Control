using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    GameObject heldObject;
    Transform prevParent;
    bool isHolding = false;
    public float grabDistance = 3;
    public float throwStrength = 1;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hitRay;
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * grabDistance, Color.green); ;
        if(ButtonActionManager.WestFaceButtonIsDown && isHolding)
        {
            heldObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //heldObject.GetComponent<Rigidbody>()
            heldObject.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * throwStrength,ForceMode.Impulse);
        }
        bool isHit = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward * grabDistance, out hitRay);
        if (isHit)
        {
            if (hitRay.collider.gameObject.tag.Equals("Grabbable") && ButtonActionManager.SouthFaceButtonIsDown){
                prevParent = hitRay.collider.gameObject.transform.parent;
                heldObject = hitRay.collider.gameObject;
                //heldObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                isHolding = true;
                hitRay.collider.gameObject.transform.parent = Camera.main.transform;
            }

        }
        else
        {
            Debug.Log("NOPE");
        }
    }
}
