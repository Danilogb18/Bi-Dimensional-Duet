using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class CheckGround : MonoBehaviour
{
     
   public static bool canJump;
   public Animator playeranim;
   //public Animator Button;
   //public Animator Button2;
   //public Animator GreenButton;
   public static bool platformController; //No borres las variables de platformcontroller (ni verde ni lo que sea). Ya estan en otro script ordenadas pero la siguien llamando desde aqui.
   public static bool greenPlatformController;
   public static bool grounded;
   //public AudioSource botonSound;
   


    private void Start() {
         platformController = false;
         //greenPlatformController = false;    esto se decide desde  el script greenplatformcontroller con un plkayer pref
    }

   private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.tag == "ground")
        {
        playeranim.SetBool("jumping", false);
        canJump = true;
        }

        if (collision.transform.tag == "Platforms")
        {
           playeranim.SetBool("jumping", false);
           canJump = true;
        }

        if (collision.transform.tag == "button")
        {
           playeranim.SetBool("jumping", false);
           canJump = true;
        }

       

        if ((collision.transform.tag != "ground") && (collision.transform.tag != "button") && collision.transform.tag != "Platforms") 
        {
        playeranim.SetBool("jumping", true);
        canJump = false;}

        if (collision.transform.tag == "Box")
        {
        playeranim.SetBool("jumping", false);
        canJump = true;
        }


         if (collision.transform.tag == "Minibox")
        {
        playeranim.SetBool("jumping", false);
        canJump = true;
        }


        if (collision.transform.tag == "buttomwall") 
        {
        playeranim.SetBool("jumping", false);
        canJump = true;}




        //   if (collision.transform.tag == "button") 
        //      {platformController = !platformController;
        //      Button.SetBool("pressed", true);
        //      Button2.SetBool("pressed", true);
        //      botonSound.Play();
        //      playeranim.SetBool("jumping", false);
        //      canJump = true;}

        //  if (collision.transform.tag != "button")
        //  {
        //      Button.SetBool("pressed", false);
        //      Button2.SetBool("pressed", false);
        //  }

        //  if (collision.transform.tag == "GreenButton") 
        //  {greenPlatformController = !greenPlatformController;
        //  GreenButton.SetBool("pressed", true);
        //  botonSound.Play();
        //  playeranim.SetBool("jumping", false);
        //  canJump = true;}

        //  if (collision.transform.tag != "GreenButton")
        //  {
        //      GreenButton.SetBool("pressed", false);
        //  }


 
      
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "ground")
        {
             canJump = true;
             playeranim.SetBool("jumping", false);
        }

        if (other.transform.tag == "Box")
        {
            canJump = true;
            playeranim.SetBool("jumping", false);
        }
        
    }



  


        
    }