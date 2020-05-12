using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is used for updating tiles when the car passes through a trigger
//NOTE: CarTag is a weird way of getting a tag fo an object, will prolly change it
//In the Inspector and add the component to Awake()
public class TriggerExit : MonoBehaviour
{
    public float delay = 1f;

    public delegate void ExitAction();
    public static event ExitAction OnChunkExited;

    private bool exited = false;

    private void OnTriggerExit(Collider other)
    {
        CarTag carTag = other.GetComponent<CarTag>();
       // Debug.Log("Collision with " + carTag);
        //if (carTag != null)
        //{
            if (!exited)
            {
                exited = true;
                if (OnChunkExited != null) OnChunkExited();
                else Debug.Log("No Function To Run");
                StartCoroutine(WaitAndDeactivate());
            }
            else Debug.Log("Exited");
       // }
       // else Debug.Log("Cartag null");
    }
    IEnumerator WaitAndDeactivate()
    {
        yield return new WaitForSeconds(delay);
        //If this is removed, the exited variable never updates so if this is
        //Taken out of the pool, it wont properly trigger to spawn new chunks
        exited = false;
        LevelLayoutGenerator.AddToPool(transform.root.gameObject);
        transform.root.gameObject.SetActive(false);        
    }
}
