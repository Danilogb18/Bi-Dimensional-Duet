using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PlayerControlerLevel2 : MonoBehaviour
{
    private PlayerControls controls = null;

    public static Animator animation;
    public Renderer fondo;
    public Rigidbody2D rb;
    public float vel;
    public float jumpForce;
    public float inRepose = 0f;
    private Animator playeranim;
    public SpriteRenderer triangulito;
    public GameObject cubito;
    public AudioSource jumpSound;
    public Animator closingPanel;

    public static bool canPlay = true;
    public static bool enteredBossZone = false;



    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        playeranim = this.GetComponent<Animator>();
        canPlay = true;

    }


    void Awake()
    {
       controls = new PlayerControls();
        //Screen.SetResolution(1920, 1080, true);
    }

    private void Update() {

        //Screen.SetResolution(1920, 1080, true);
        
    }


    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }


    void FixedUpdate()
    {
        if (canPlay) 
        {Move();}

        else
        {
            rb.velocity = new Vector2(inRepose, rb.velocity.y);
        }

        if (DamageObject.life <= 0)
        {
        canPlay = false;
        CheckGround.canJump = false;
        rb.velocity = new Vector2(inRepose, rb.velocity.y);
        StartCoroutine(RestartLevel());
        
        }


        if (canPlay == false)
        {
            playeranim.SetFloat("speed", 0);
        }
    }


    public void Jump()
    {  if ((CheckGround.canJump) && (PickObject.notPickingBox) && (canPlay))
    {
       rb.AddForce(new Vector2 (0, jumpForce));
       CheckGround.canJump = false;
       playeranim.SetBool("jumping", true);
       jumpSound.Play();
       
    }


    }



    public void Move()
    {
        var movementInput = controls.Player.Movement.ReadValue<Vector2>();

        if (movementInput.x > 0)
        {
         rb.velocity = new Vector2(vel, rb.velocity.y);
         fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2 (0.009f, 0) * Time.deltaTime;
         playeranim.SetFloat("speed", 1);
        }

        else if (movementInput.x < 0)
        {
         rb.velocity = new Vector2(-vel, rb.velocity.y);
         fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2 (-0.009f, 0) * Time.deltaTime;
         playeranim.SetFloat("speed", 1);
        }

        else
        {
            rb.velocity = new Vector2(inRepose, rb.velocity.y);
            playeranim.SetFloat("speed", 0);
        }




        if (movementInput.x < 0 && PickObject.notPickingBox)
      //if (Input.GetAxisRaw("Horizontal") < 0 && PickObject.notPickingBox)
     {
        
         triangulito.flipX = true;
         cubito.transform.localScale = new Vector3(-1,1,1);
         
     }
  
     else if (movementInput.x > 0 && PickObject.notPickingBox)
     //if (Input.GetAxisRaw("Horizontal") > 0 && PickObject.notPickingBox)
     {
          
         triangulito.flipX = false;
         cubito.transform.localScale = new Vector3(1,1,1);
             
     }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "BossZone")
        {
            Debug.Log("bosszone");
            Destroy(other.gameObject);
            enteredBossZone = true;


        }
    }




    public void ShowKey()
    {
      
       
    }

    IEnumerator RestartLevel()
    {
        closingPanel.SetTrigger("finishlevel");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    
}

