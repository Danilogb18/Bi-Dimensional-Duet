using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Controller : MonoBehaviour
{
    
    void Start()
    {
        PlayerPrefs.SetInt("ActualLevel", 1);

        if (PlayerPrefs.GetInt("Checkpoint") == 1)
        {
            PlayerPrefs.SetInt("Checkpoint",1);
        }
        else
        {
            PlayerPrefs.SetInt("Checkpoint",0);
        }

    }

}
