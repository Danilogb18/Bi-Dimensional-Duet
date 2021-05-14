using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleGround : MonoBehaviour
{
     
   public static bool canJump;
   public Animator playeranim;
   public Animator Button;
   public static bool platformController;
   


    private void Start() {
         platformController = false;
    }

   private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.tag == "ground")
        {
        playeranim.SetBool("jumping", false);
        canJump = true;
        }

       

        if ((collision.transform.tag != "ground") && (collision.transform.tag != "button")) 
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




      if (collision.transform.tag == "button") 
         {platformController = !platformController;
         Button.SetBool("pressed", true);
         playeranim.SetBool("jumping", false);
         canJump = true;}

         if (collision.transform.tag != "button")
         {
             Button.SetBool("pressed", false);
         }


 
      
    }

    
    

    }
