using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public int NextCount=1;

    public GameObject SkinColor;
    public GameObject IrisColor;
    public GameObject HairColor;
    public GameObject HairType;
    // Start is called before the first frame update
    void Start()
    {
        SkinColor.SetActive(true);
        IrisColor.SetActive(false);
        HairColor.SetActive(false);
        HairType.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (NextCount == 1)
        {
            SkinColor.SetActive(true);
            HairColor.SetActive(false);
            HairType.SetActive(false);
            IrisColor.SetActive(false);
        }

        if (NextCount == 3)
        {
            SkinColor.SetActive(false);
            HairColor.SetActive(true);
            HairType.SetActive(false);
            IrisColor.SetActive(false);
        }

        if (NextCount == 2)
        {
            SkinColor.SetActive(false);
            HairColor.SetActive(false);
            HairType.SetActive(true);
            IrisColor.SetActive(false);
        }

        if (NextCount == 4)
        {
            SkinColor.SetActive(false);
            HairColor.SetActive(false);
            HairType.SetActive(false);
            IrisColor.SetActive(true);
        }

        if (NextCount > 4)
        {
            NextCount = 1;
        }

        if (NextCount < 1)
        {
            NextCount = 4;
        }
    }

    public void NextPressed()
    {
        NextCount++;
    }

    public void PreviousPressed()
    {
        NextCount--;
    }
}
