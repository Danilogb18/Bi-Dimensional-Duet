using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    Animator anim;
    public AudioSource botonSound;

    void Start()
    {
       anim = GetComponentInParent<Animator>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
             anim.SetBool("pressed", true);
             CheckGround.platformController = !CheckGround.platformController;
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
