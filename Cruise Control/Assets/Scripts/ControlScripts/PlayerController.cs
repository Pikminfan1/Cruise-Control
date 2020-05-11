using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script will eventually be used for actions that don't involve driving such as the wind shield wipers and windows
public class PlayerController : MonoBehaviour
{
    
    public void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
       
        //Weve hit a wall, p stressful
        if (collision.collider.gameObject.tag.Equals("Wall"))
        {
            
            Debug.Log("I hit a wall");
            GameManager.stress += 10;
            Debug.Log(GameManager.stress);
        }
    }
}
