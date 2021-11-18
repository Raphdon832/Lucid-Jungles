using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public int count=1;

    public GameObject Food1;
    public GameObject Food2;
    public GameObject Food3;
    // Start is called before the first frame update
    void Start()
    {
        Food1.SetActive(false);
        Food2.SetActive(false);
        Food3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
            if (count == 1)
            {
                Food1.SetActive(true);
                Food2.SetActive(false);
                Food3.SetActive(false);
            }

            if (count == 2)
            {
                Food1.SetActive(false);
                Food2.SetActive(true);
                Food3.SetActive(false);
            }

            if (count == 3)
            {
                Food1.SetActive(false);
                Food2.SetActive(false);
                Food3.SetActive(true);
            }

        if (count > 3)
        {
            count = 1;
        }

        if (count < 1)
        {
            count = 3;
        }

    }


    public void OnNextPressed()
    {
        count++;
    }

    public void OnPreviousPressed()
    {
        count--;
    }
}
