using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighStressEffect : MonoBehaviour
{
    public RawImage circle;

    private float alpha;

    // Start is called before the first frame update
    void Start()
    {
        circle.enabled = false;
        alpha = 0;
        circle.color = new Color(circle.color.r, circle.color.g, circle.color.b, alpha);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerStats.stress >= 80)
        {
            //Instantiate(circle, transform.position, Quaternion.identity);
            circle.enabled = true;
            alpha = Mathf.SmoothStep(alpha, 0.6f, Time.deltaTime);
            //Debug.Log("Alpha: " + alpha);
            //StartCoroutine(Blinking());
            circle.color = new Color(circle.color.r, circle.color.g, circle.color.b, alpha);

        }
        else
        {
            circle.enabled = false;
        }
    }

    IEnumerator Blinking()
    {
        circle.color = new Color(circle.color.r, circle.color.g, circle.color.b, alpha);
        yield return new WaitForSeconds(0.5f);
        circle.color = new Color(circle.color.r, circle.color.g, circle.color.b, 0);
    }
}
