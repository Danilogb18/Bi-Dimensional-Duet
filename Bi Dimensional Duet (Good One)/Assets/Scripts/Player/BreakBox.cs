using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BreakBox : MonoBehaviour
{

    Animator anim;
    public AudioSource breakBoxSound;
    
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }


    
    private void OnTriggerEnter2D(Collider2D other)
     {
            if (other.transform.tag == "Breakbox")
            {
               anim.SetTrigger("breakbox");
               breakBoxSound.Play();
               StartCoroutine((Breakthebox())); 
               
            }
     }

    IEnumerator Breakthebox()
     {
          yield return new WaitForSeconds(0.3f);
          Destroy(this.gameObject);
         
         
     }


}
