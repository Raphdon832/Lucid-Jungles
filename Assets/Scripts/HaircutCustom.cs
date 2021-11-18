using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaircutCustom : MonoBehaviour
{
    public GameObject Hair1;
    public GameObject Hair2;
    public GameObject Hair3;
    public GameObject Hair4;
    public GameObject Hair5;
    public GameObject Hair6;
    public float      NoHair;

    public int HairSelected;

    public Renderer thisHair1;
    public Renderer thisHair2;
    public Renderer thisHair3;
    public Renderer thisHair4;
    public Renderer thisHair5;
    public Renderer thisHair6;
    public Material[] newMat;
    // Start is called before the first frame update
    void Start()
    {
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        Hair4.SetActive(false);
        Hair5.SetActive(false);
        Hair6.SetActive(false);
    }

    void Update()
    {
        /*if (NoHair > 1)
        {
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        NoHair = 0;
        }*/
    }

    public void OnCancel()
    {
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        Hair4.SetActive(false);
        Hair5.SetActive(false);
        Hair6.SetActive(false);

        HairSelected = 0;
        
    }


   public void ClickHair1()
   {
        /*if (NoHair > 1)
        {
          Hair1.SetActive(true);
          Hair2.SetActive(false);
          Hair3.SetActive(false);
        }
        NoHair++;*/
        
        Hair1.SetActive(true);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        Hair4.SetActive(false);
        Hair5.SetActive(false);
        Hair6.SetActive(false);

        HairSelected = 1;
    }

    public void ClickHair2()
   {
        /*if (NoHair > 1)
        {
          Hair1.SetActive(false);
          Hair2.SetActive(true);
          Hair3.SetActive(false);
        }
        NoHair++;*/
        Hair1.SetActive(false);
        Hair2.SetActive(true);
        Hair3.SetActive(false);
        Hair4.SetActive(false);
        Hair5.SetActive(false);
        Hair6.SetActive(false);

        HairSelected = 2;

    }

    public void ClickHair3()
   {
        /* if (NoHair > 1)
        {
          Hair1.SetActive(false);
          Hair2.SetActive(false);
          Hair3.SetActive(true);
        }
        NoHair++;*/
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(true);
        Hair4.SetActive(false);
        Hair5.SetActive(false);
        Hair6.SetActive(false);

        HairSelected = 3;

    }

    public void ClickHair4()
   {
        /* if (NoHair > 1)
        {
          Hair1.SetActive(false);
          Hair2.SetActive(false);
          Hair3.SetActive(true);
        }
        NoHair++;*/
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        Hair4.SetActive(true);
        Hair5.SetActive(false);
        Hair6.SetActive(false);

        HairSelected = 4;
    }

    public void ClickHair5()
   {
        /* if (NoHair > 1)
        {
          Hair1.SetActive(false);
          Hair2.SetActive(false);
          Hair3.SetActive(true);
        }
        NoHair++;*/
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        Hair4.SetActive(false);
        Hair5.SetActive(true);
        Hair6.SetActive(false);

        HairSelected = 5;
    }

    public void ClickHair6()
   {
        /* if (NoHair > 1)
        {
          Hair1.SetActive(false);
          Hair2.SetActive(false);
          Hair3.SetActive(true);
        }
        NoHair++;*/
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        Hair4.SetActive(false);
        Hair5.SetActive(false);
        Hair6.SetActive(true);

        HairSelected = 6;
    }

    public void SetTheColor1()
    {

        thisHair1.sharedMaterial = newMat[0];
        thisHair2.sharedMaterial = newMat[0];
        thisHair3.sharedMaterial = newMat[0];
        thisHair4.sharedMaterial = newMat[0];
        thisHair5.sharedMaterial = newMat[0];
        thisHair6.sharedMaterial = newMat[0];
        //newRend.material.SetColor("_Color", Color.red);
    }

    public void SetTheColor2()
    {

        thisHair1.sharedMaterial = newMat[1];
        thisHair2.sharedMaterial = newMat[1];
        thisHair3.sharedMaterial = newMat[1];
        thisHair4.sharedMaterial = newMat[1];
        thisHair5.sharedMaterial = newMat[1];
        thisHair6.sharedMaterial = newMat[1];

        //newRend.material.color = new Color(255, 153, 1);
        //mat.color = new Color(255, 153, 1);
    }

    public void SetTheColor3()
    {
        thisHair1.sharedMaterial = newMat[2];
        thisHair2.sharedMaterial = newMat[2];
        thisHair3.sharedMaterial = newMat[2];
        thisHair4.sharedMaterial = newMat[2];
        thisHair5.sharedMaterial = newMat[2];
        thisHair6.sharedMaterial = newMat[2];
    }

    public void SetTheColor4()
    {
        thisHair1.sharedMaterial = newMat[3];
        thisHair2.sharedMaterial = newMat[3];
        thisHair3.sharedMaterial = newMat[3];
        thisHair4.sharedMaterial = newMat[3];
        thisHair5.sharedMaterial = newMat[3];
        thisHair6.sharedMaterial = newMat[3];
    }

    public void SetTheColor5()
    {
        thisHair1.sharedMaterial = newMat[4];
        thisHair2.sharedMaterial = newMat[4];
        thisHair3.sharedMaterial = newMat[4];
        thisHair4.sharedMaterial = newMat[4];
        thisHair5.sharedMaterial = newMat[4];
        thisHair6.sharedMaterial = newMat[4];
    }

    public void SetTheColor6()
    {
        thisHair1.sharedMaterial = newMat[5];
        thisHair2.sharedMaterial = newMat[5];
        thisHair3.sharedMaterial = newMat[5];
        thisHair4.sharedMaterial = newMat[5];
        thisHair5.sharedMaterial = newMat[5];
        thisHair6.sharedMaterial = newMat[5];
    }

    public void SetTheColor7()
    {
        thisHair1.sharedMaterial = newMat[6];
        thisHair2.sharedMaterial = newMat[6];
        thisHair3.sharedMaterial = newMat[6];
        thisHair4.sharedMaterial = newMat[6];
        thisHair5.sharedMaterial = newMat[6];
        thisHair6.sharedMaterial = newMat[6];
    }

    public void SetTheColor8()
    {
        thisHair1.sharedMaterial = newMat[7];
        thisHair2.sharedMaterial = newMat[7];
        thisHair3.sharedMaterial = newMat[7];
        thisHair4.sharedMaterial = newMat[7];
        thisHair5.sharedMaterial = newMat[7];
        thisHair6.sharedMaterial = newMat[7];
    }

    public void SetTheColor9()
    {
        thisHair1.sharedMaterial = newMat[8];
        thisHair2.sharedMaterial = newMat[8];
        thisHair3.sharedMaterial = newMat[8];
        thisHair4.sharedMaterial = newMat[8];
        thisHair5.sharedMaterial = newMat[8];
        thisHair6.sharedMaterial = newMat[8];
    }

    public void SetTheColor10()
    {
        thisHair1.sharedMaterial = newMat[9];
        thisHair2.sharedMaterial = newMat[9];
        thisHair3.sharedMaterial = newMat[9];
        thisHair4.sharedMaterial = newMat[9];
        thisHair5.sharedMaterial = newMat[9];
        thisHair6.sharedMaterial = newMat[9];
    }

    public void SetTheColor11()
    {
        thisHair1.sharedMaterial = newMat[10];
        thisHair2.sharedMaterial = newMat[10];
        thisHair3.sharedMaterial = newMat[10];
        thisHair4.sharedMaterial = newMat[10];
        thisHair5.sharedMaterial = newMat[10];
        thisHair6.sharedMaterial = newMat[10];
    }

    public void SetTheColor12()
    {
        thisHair1.sharedMaterial = newMat[11];
        thisHair2.sharedMaterial = newMat[11];
        thisHair3.sharedMaterial = newMat[11];
        thisHair4.sharedMaterial = newMat[11];
        thisHair5.sharedMaterial = newMat[11];
        thisHair6.sharedMaterial = newMat[11];
    }
}
