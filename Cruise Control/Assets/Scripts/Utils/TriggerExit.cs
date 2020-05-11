using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is used for updating tiles when the car passes through a trigger
//NOTE: This method currently is not using Object Pooling and should be updated to fix
//that, also CarTag is a weird way of getting a tag fo an object, will prolly change it
//In the Inspector and add the component to Awake()
public class TriggerExit : MonoBehaviour
{
    public float delay = 5f;

    public delegate void ExitAction();
    public static event ExitAction OnChunkExited;

    private bool exited = false;

    private void OnTriggerExit(Collider other)
    {
        CarTag carTag = other.GetComponent<CarTag>();
        if(carTag != null)
        {
            if (!exited)
            {
                exited = true;
                OnChunkExited();
                StartCoroutine(WaitAndDeactivate());
            }
        }
    }
    IEnumerator WaitAndDeactivate()
    {
        yield return new WaitForSeconds(delay);

        transform.root.gameObject.SetActive(false);

    }
}
