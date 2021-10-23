using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionController : MonoBehaviour
{
    public Text resolutionText;
    void Start()
    {
        //Screen.SetResolution(1920, 1080, true);

        Debug.Log(Screen.currentResolution);
    }

    // Update is called once per frame
    void Update()
    {
        resolutionText.text = Screen.width + "," + Screen.height;

        // if(Screen.fullScreen) 
        // {
        //     Screen.SetResolution(1920, 1080, true);
        // }

        // else if (Screen.fullScreen == false)
        // {
        //     Screen.SetResolution(1280, 1720, true);

        // }
    }
}
