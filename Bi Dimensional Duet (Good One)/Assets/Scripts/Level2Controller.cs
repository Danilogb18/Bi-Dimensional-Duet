using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Controller : MonoBehaviour
{
    public GameObject keyCanvas;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("ActualLevel") == 1)
        {
            PlayerPrefs.SetInt("Checkpoint", 0);
            PlayerPrefs.SetInt("pickedVertices", 0);
            keyCanvas.SetActive(false);
            NewControls.enteredBossZone = false;
            GetKey.gotKey = false;
        }


        PlayerPrefs.SetInt("ActualLevel", 2);

    }

    private void Start()
    {
        if (GetKey.gotKey == false)
        {
            GetKey.gotKey = false;
        }
    }
}
