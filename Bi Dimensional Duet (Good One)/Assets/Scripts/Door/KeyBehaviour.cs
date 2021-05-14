using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    public Transform cubitoKeyZone;
    public Transform trianguloKeyZone;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (GetKey.gotKey)
        {
            if (ChangePlayer.cubitoActive)
            {
                transform.SetParent(cubitoKeyZone);
                transform.position = cubitoKeyZone.position;
            }
            else
            {
                transform.SetParent(trianguloKeyZone);
                transform.position = trianguloKeyZone.position;
            }
        }
    }

    
}
