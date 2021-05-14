using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Dye : MonoBehaviour
{
    Animator anim; // el anim de cada enemigo  
    public GameObject particles;
    public AudioSource deathSound;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Breakbox")
        {
            if(DamageObject.vulnerable)
            {
            particles.SetActive(true);
            Destroy(gameObject);
            DamageObject.vulnerable = true;
            deathSound.Play();
            }
        }
    }

    
    void Update()
    {
        particles.transform.position = transform.position;
    }
}
