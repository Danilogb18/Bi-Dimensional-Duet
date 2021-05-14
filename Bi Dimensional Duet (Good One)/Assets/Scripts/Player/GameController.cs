using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour{
     
    
    public static Animator animation;
    public Renderer fondo;
    public Rigidbody2D rb;
    public float vel;
    public float jumpForce;
    public float inRepose = 0f;
    private Animator playeranim;
    public SpriteRenderer triangulito;
    public GameObject cubito;
   
   
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
     playeranim = GetComponent<Animator>();

    }

     void FixedUpdate() {

     if (Input.GetKey("left"))
     //if (Input.GetAxisRaw("Horizontal") < 0)
     {
         rb.velocity = new Vector2(-vel, rb.velocity.y);
         fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2 (-0.009f, 0) * Time.deltaTime;
         playeranim.SetFloat("speed", 1);
     }
  
     else if (Input.GetKey("right"))
     //else if (Input.GetAxisRaw("Horizontal") > 0)
     {
         rb.velocity = new Vector2(vel, rb.velocity.y);   
         
         fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2 (0.009f, 0) * Time.deltaTime;
         playeranim.SetFloat("speed", 1);
             
     }
     else
        {
         rb.velocity = new Vector2(inRepose, rb.velocity.y);
         playeranim.SetFloat("speed", 0);
        }



      if (Input.GetKey("left") && PickObject.notPickingBox)
      //if (Input.GetAxisRaw("Horizontal") < 0 && PickObject.notPickingBox)
     {
        
         triangulito.flipX = true;
         cubito.transform.localScale = new Vector3(-1,1,1);
         
     }
  
     else if (Input.GetKey("right") && PickObject.notPickingBox)
     //if (Input.GetAxisRaw("Horizontal") > 0 && PickObject.notPickingBox)
     {
          
         triangulito.flipX = false;
         cubito.transform.localScale = new Vector3(1,1,1);
             
     }





    

// gameObject.GetComponent<Transform>().localScale = new Vector3(-1,1,1);
//gameObject.GetComponent<SpriteRenderer>().flipX = true;


    
 }

   private void Update() {
    if (Input.GetKeyDown("up") && (CheckGround.canJump) && (PickObject.notPickingBox))
    {
       Debug.Log("salta");
       rb.AddForce(new Vector2 (0, jumpForce));
       CheckGround.canJump = false;
       gameObject.GetComponent<Animator>().SetBool("jumping", true);
    }
       
    if (DamageObject.life <= 0)
    {
    Destroy(gameObject);
    }
   }

  
    
}
