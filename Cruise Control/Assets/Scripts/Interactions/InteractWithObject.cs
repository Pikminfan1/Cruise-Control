using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    GameObject heldObject; //Holds information on currently held object
    Transform prevParent;
    [SerializeField] public bool isHolding = false; //Used to determine if another interaction can occur
    public float grabDistance = 3; //Distance the Player can grab from
    public float throwStrength = 100; //Strength Player can throw object
    bool throwObj = false;
    Interact currentInteraction;
    Interact prevInteraction;


    // Update is called once per frame
    void Update()
    {
        //Holds information about what the player is looking at
        RaycastHit hitRay;

        if (ButtonActionManager.WestFaceButtonIsDown && isHolding)
        {
            throwObj = true;
            return;
        }
        
            bool isHit = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward * grabDistance, out hitRay);
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * grabDistance, Color.green); ;
            if (isHit)
            {
            if (hitRay.collider.gameObject.tag.Equals("Interactable") && !isHolding)
            {


                heldObject = hitRay.collider.gameObject;
                Debug.Log(heldObject.name);
                //Use this to decide whether we can grab, use, or both on the interaction
                currentInteraction = heldObject.GetComponent<Interact>();
                if (prevInteraction != currentInteraction)
                {
                    HideOutline();
                    ShowOutline();
                }

                prevInteraction = currentInteraction;
                //For some reason, sometimes the currentInteraction is somehow set to null...
                Debug.Log("I can use current interaction" + currentInteraction.CanUse);
                if (currentInteraction != null && currentInteraction.CanGrab && ButtonActionManager.SouthFaceButtonIsDown)
                {
                    prevParent = hitRay.collider.gameObject.transform.parent;
                    heldObject = hitRay.collider.gameObject;
                    isHolding = true;
                    hitRay.collider.gameObject.transform.parent = Camera.main.transform;
                    currentInteraction.resetHighLight();

                }


                if (currentInteraction.CanUse && ButtonActionManager.NorthFaceButtonIsDown)
                {
                    Debug.Log("Tried to use");
                    currentInteraction.Use();
                }
            
                }
                else
                {
                    HideOutline();
                }
            }
            else
            {
                HideOutline();
            }
        if (throwObj)
        {
            throwObject();
        }
        
    }
    
    private void throwObject()
    {
        if (heldObject.GetComponent<Rigidbody>() != null)
        {
            heldObject.transform.parent = null;
            heldObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            heldObject.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * throwStrength, ForceMode.Impulse);
            isHolding = false;
        }

    }
    private void ShowOutline()
    {
        if(currentInteraction != null)
        {
            currentInteraction.highLight();
        }
    }
    private void HideOutline()
    {
        if(prevInteraction != null)
        {
            prevInteraction.resetHighLight();
            prevInteraction = null;
        }
    }
}
