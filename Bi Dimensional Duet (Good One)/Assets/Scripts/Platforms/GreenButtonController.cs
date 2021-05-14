using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GreenButtonController : MonoBehaviour
{
    Animator anim;
    public AudioSource botonSound;


    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            anim.SetBool("pressed", true);
            CheckGround.greenPlatformController = !CheckGround.greenPlatformController;
            botonSound.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
             anim.SetBool("pressed", false);
             
        }
    }
}
