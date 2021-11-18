using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScreenieButton()
    {
        ScreenshotHandler.TakeScreenshot_Static(800, 800);
    }
}
