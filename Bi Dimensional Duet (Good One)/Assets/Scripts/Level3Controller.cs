using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Controller : MonoBehaviour
{
    void Awake() 
    {
        if (PlayerPrefs.GetInt("ActualLevel") == 2)
        {
            PlayerPrefs.SetInt("Checkpoint", 0);
            PlayerPrefs.SetInt("pickedVertices", 0);
            NewControls.enteredBossZone = false;
            GetKey.gotKey = false;
        }

        PlayerPrefs.SetInt("ActualLevel", 3);
    }


    void Start()
    {
        if (GetKey.gotKey == false)
        {
            GetKey.gotKey = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
