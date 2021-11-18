using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAvatar : MonoBehaviour
{
    public GameObject Avatar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnRight();
        TurnLeft();

        if (Input.GetKey("q"))
        {
            transform.Rotate(0, 32*Time.deltaTime, 0);
        }

        if (Input.GetKey("e"))
        {
            transform.Rotate(0, -32*Time.deltaTime, 0);
        }

    }

    public void TurnRight()
    {
        transform.Rotate(0, -12, 0);
    }

    public void TurnLeft()
    {
        transform.Rotate(0, 12, 0);
    }
}
