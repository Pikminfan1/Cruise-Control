using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vibrate : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 50;
    public float amount = 0.01f;
    public Transform[] childrenTrans;


    // Update is called once per frame
    void Update()
    {

        if (ChildCry.isCrying)
        {
            for (int i = 0; i < childrenTrans.Length; i++)
            {
                childrenTrans[i].Translate(0, Mathf.Sin(Time.time * speed) * amount, 0);
            }
        }
    }
}
