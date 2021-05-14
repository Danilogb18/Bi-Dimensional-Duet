using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWall : MonoBehaviour
{
    public static float velocidad = 80f;

   private void OnTriggerEnter2D(Collider2D collision) {
     if (collision.transform.tag == "wall")
        {
            velocidad = 10f;
        }
     if (collision.transform.tag == "buttomwall")
        {
            velocidad = 10f;
        }
   }

   private void OnTriggerExit2D(Collider2D collision){
   if (collision.transform.tag == "wall")
        {
            velocidad = 80f;
        }

     if (collision.transform.tag == "buttomwall")
        {
            velocidad = 80f;
        }


   }
}
