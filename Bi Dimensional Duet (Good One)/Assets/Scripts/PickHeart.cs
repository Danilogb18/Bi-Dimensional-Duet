using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PickHeart : MonoBehaviour
{
    public Animator animator;
    private bool notpicked;
    public AudioSource heartSound;

    void Start()
    {
        animator = this.GetComponent<Animator>();
        notpicked = true;
    }

    
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && notpicked)
        {
            heartSound.Play();
            notpicked = false;
            animator.SetTrigger("HeartPicked");
            Destroy(this.gameObject, 0.5f);



            if (DamageObject.life < 3)
            {
                DamageObject.life++;
            }
        }
    }
}
