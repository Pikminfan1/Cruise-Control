using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script will eventually be used for actions that don't involve driving such as the wind shield wipers and windows
public class PlayerController : MonoBehaviour
{
    public AudioSource CollisionFX;
    public AudioClip[] playerSounds;
    //public AudioClip collision;

    public void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
       
        //Weve hit a wall, p stressful
        if (collision.collider.gameObject.tag.Equals("Wall"))
        {
            //Play crash sound effect
            CollisionFX.clip = playerSounds[0];
            CollisionFX.volume = 0.15f;
            CollisionFX.Play(); 
            Debug.Log("I hit a wall");
            //GameManager.stress += 10;
            if(GameManager.stress + 10 > GameManager.maxStress)
            {
                GameManager.stress = GameManager.maxStress;
            }
            else
            {
                GameManager.stress += 10;
            }
            
            //Debug.Log(GameManager.stress);
        }
    }
}
