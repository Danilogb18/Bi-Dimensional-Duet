using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlatformController : MonoBehaviour
{
    public GameObject activated;
    public GameObject notactivated;
    void Start()
    {
        if (PlayerPrefs.GetInt("GreenPlatform") == 1)
        {
           CheckGround.greenPlatformController = true;
        }

        if (PlayerPrefs.GetInt("GreenPlatform") == 2)
        {
           CheckGround.greenPlatformController = false;
        }
    }

    
    void Update()
    {
        if (CheckGround.greenPlatformController)
        {
        Debug.Log("1");
        activated.gameObject.SetActive (true);
        notactivated.gameObject.SetActive (false);
        PlayerPrefs.SetInt("GreenPlatform", 1);
        }



        else
        {
        Debug.Log("2");
        activated.gameObject.SetActive (false);
        notactivated.gameObject.SetActive (true);
        PlayerPrefs.SetInt("GreenPlatform", 2);
        }
    }
}
