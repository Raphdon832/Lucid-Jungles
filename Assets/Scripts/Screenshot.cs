using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public GameObject SkinColorHolder;
    public GameObject HairTypeHolder;
    public GameObject HairColorHolder;
    public GameObject IrisColorHolder;

    private void Start()
    {
        
    }

    public void OnSavePressed()
    {
        SkinColorHolder.SetActive(false);
        HairColorHolder.SetActive(false);
        HairTypeHolder.SetActive(false);
        IrisColorHolder.SetActive(false);
    }
}
