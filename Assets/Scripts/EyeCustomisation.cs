using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeCustomisation : MonoBehaviour
{
    public Renderer newRend;
    public Material[] newMat;
    public Material[] newTexture;

    // Start is called before the first frame update
    void Start()
    {
        newTexture[1] = newMat[1];
    }

     public void SetTheColor1()
    {

        newRend.sharedMaterial = newMat[0];
    }

    public void SetTheColor2()
    {
        newRend.sharedMaterial = newMat[1];
    }

     public void SetTheColor3()
    {
        newRend.sharedMaterial = newMat[2];
    }

    public void SetTheColor4()
    {
        newRend.sharedMaterial = newMat[3];
    }

    public void SetTheColor5()
    {
        newRend.sharedMaterial = newMat[4];
    }

    public void SetTheColor6()
    {
        newRend.sharedMaterial = newMat[5];
    }

    public void SetTheColor7()
    {
        newRend.sharedMaterial = newMat[6];
    }

    public void SetTheColor8()
    {
        newRend.sharedMaterial = newMat[7];
    }

    public void SetTheColor9()
    {
        newRend.sharedMaterial = newMat[8];
    }

    public void SetTheColor10()
    {
        newRend.sharedMaterial = newMat[9];
    }

    public void SetTheColor11()
    {
        newRend.sharedMaterial = newMat[10];
    }

    public void SetTheColor12()
    {
        newRend.sharedMaterial = newMat[11];
    }
}
