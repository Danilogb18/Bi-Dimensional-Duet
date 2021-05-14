using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GetKey : MonoBehaviour
{
    public static bool gotKey;
    private Transform keyPoint;
    public GameObject keyCanvas;
    public AudioSource keySound;
    

    void Start()
    {
        gotKey = false;
        keyPoint = GameObject.FindGameObjectWithTag("KeyPoint").GetComponent<Transform>();

        if (Vertices.pickedVertices == 4)
        {
            if(PlayerPrefs.GetInt("ActualLevel") == 1)
            {gotKey = true;}
        }

        if (gotKey)
        {
            keyCanvas.SetActive(true);
        }

        else
        {
            keyCanvas.SetActive(false);
        }
    }

    
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Key")
        {
            //other.transform.position = gameObject.transform.position;
            //other.transform.SetParent(keyPoint);
            gotKey = true;
            keyCanvas.SetActive(true);
            other.gameObject.SetActive(false);
            keySound.Play();
        }
    }
}
