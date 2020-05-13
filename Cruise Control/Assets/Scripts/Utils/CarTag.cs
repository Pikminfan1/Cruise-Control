using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Followed Example for this class, exists so that the car has a tag to be identified with,
//Though this can be done through the inspector, not sure why the guy did it that way, will
//Prolly Change it in TriggerExit
public class CarTag : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided with " + collision.gameObject.name);
    }
}
