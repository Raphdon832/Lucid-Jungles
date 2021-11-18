using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public int BlinkCount;
    public Animator BlinkAnim;
    public bool Anim;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(turnoff());
    }

    // Update is called once per frame
    void Update()
    {
        /*BlinkCount += 1;
        if (BlinkCount >= 400)
        {
            BlinkAnim.enabled = false;
            BlinkCount =0;
        }
        Debug.Log(BlinkCount);

        if (BlinkAnim.enabled == false)
        {
            BlinkAnim.enabled = true;
        }*/
        
        StartCoroutine(turnon());
    }
    IEnumerator turnoff()
    {
        yield return new WaitForSeconds(20f);
        BlinkAnim.enabled = false;
    }

    IEnumerator turnon()
    {
        yield return new WaitForSeconds(40f);
        BlinkAnim.enabled = true;
    }
}
