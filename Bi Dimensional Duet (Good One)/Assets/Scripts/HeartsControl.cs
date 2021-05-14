using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HeartsControl : MonoBehaviour
{
    public GameObject[] hearts;
   


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DamageObject.life < 1)
        {
            //Destroy(hearts[0].gameObject);
            hearts[0].SetActive(false);
            
        }
        else if (DamageObject.life < 2)
        {
            //Destroy(hearts[1].gameObject);
            hearts[1].SetActive(false);
            hearts[0].SetActive(true);
        }
        else if (DamageObject.life < 3)
        {
            //Destroy(hearts[2].gameObject);
            hearts[2].SetActive(false);
            hearts[1].SetActive(true);
            hearts[0].SetActive(true);
        }

        else if (DamageObject.life == 3)
        {
            hearts[2].SetActive(true);
            hearts[1].SetActive(true);
            hearts[0].SetActive(true);
        }
    }
}
