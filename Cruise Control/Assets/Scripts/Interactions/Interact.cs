using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Parent Class for interactable objects.
//Objects can be grabbed (trash)
//Used (yelling at children)
//or both (picking up soda can and drinking from it)
//Use is called when the player interacts (north face button) in InteractWithObject
public class Interact : MonoBehaviour
{
    public Transform homeSpawn;
    public string interactName = "NONE";
    public bool CanUse;
    public bool CanGrab;
    public float highlightWidth = 0;
    public Color highlightColor;
    private MeshRenderer meshRend;
    public virtual void Use()
    {
        Debug.Log("ATEMPTED TO " + interactName);
    }
    public void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
    }
    public virtual void respawn()
    {
        //Used to move interactable object to home location, glovebox/ seat
    }
    public virtual void highLight()
    {
        //meshRend.material.SetColor("_OutlineColor", highlightColor);
        meshRend.material.SetFloat("_Outline", highlightWidth);
    }
    public virtual void resetHighLight()
    {
        meshRend.material.SetFloat("_Outline", 0);
    }
}
