using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Singleton Abstract template

//There wil only be one game manager, to access it, you only need to
// GameManager.Instance.ExampleMethod()
//Singletons can be accessed by anything, but shouldnt be used to access instantiated thing
//For instance, The player can access the game manager, but the game manager shouldnt access the player
//The game manager can also access other managers, as they are not instances created during runtime
//When Making managers, inherit from this template 
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                
                Debug.LogError(typeof(T).ToString() + " is null.");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this as T;

        Init();
    }

    public virtual void Init()
    {
        //Optional to override
        //This is called on awake and can
        //Be used to Initialize anything needed
    }

}
