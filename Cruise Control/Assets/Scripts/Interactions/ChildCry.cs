using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is an interaction to be attatched to the sole child object in the back seat,
//Any animations/ sounds associated with the child object and the logic to continue crying 
//Is found here. 
public class ChildCry : Interact
{
    static public bool isCrying;
    static AudioSource cry;

    //Initializes information regarding Child
    new void Start()
    {
        base.Start();
        cry = GetComponent<AudioSource>();
        CanUse = true;
        CanGrab = false;
        interactName = "Make Child Cry";
    }


    //Called to begin audio loop and any other recurring behaviors for crying
    public static void startCrying()
    {
        cry.Play();
        isCrying = true;
        cry.loop = true;
    }
    //Ends Crying loop and sets Crying status to false
    public static void shutUp()
    {
        isCrying = false;
        cry.loop = false;
    }

    //Inherited from Interact, called when player interacts with child
    public override void Use()
    {
        shutUp();
        resetHighLight();
    }
    public override void highLight()
    {
        if (isCrying)
        {
            base.highLight();
        }
    }
}
