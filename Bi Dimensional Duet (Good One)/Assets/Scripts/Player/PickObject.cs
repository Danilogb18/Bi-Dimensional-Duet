using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PickObject : MonoBehaviour
{
    private PlayerControls controls = null;

    public GameObject handPoint;
    public GameObject handPoint1;
    private GameObject pickedObject = null;
    public static bool notPickingBox = true;
    public Animator animatorBox;
    public AudioSource dragSound;
    PanelManager panelmanager;


    void Awake()
    {
       controls = new PlayerControls();
    }


    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }


    void Start()
    {
        panelmanager = GameObject.FindGameObjectWithTag("PlayerInteractionZone").GetComponent<PanelManager>();
    }
    void Update()
    {
            
    
    }

     

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Box")
        {
            animatorBox.SetBool("Nearbox", true);
            panelmanager.Boxes();
        }
        
        if (other.transform.tag == "Minibox")
        {
            
            panelmanager.Boxes();
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Box")
        {
            animatorBox.SetBool("Nearbox", false);
            panelmanager.NoBoxes();
            other.transform.SetParent(null);
            notPickingBox = true;
            
        }
        if (other.transform.tag == "Minibox" && other.transform.tag != "ground")
        {
            panelmanager.NoBoxes();
            other.transform.SetParent(null);
        }
    }



    public void OnTriggerStay2D(Collider2D other)
    {
        
         var movementInput = controls.Player.Grab.ReadValue<Vector2>();
        if (other.transform.tag == "Box" && CheckGround.canJump)
        {
            
            if (pickedObject == null)
            {

                if (movementInput.x > 0)
                {
                    

                other.transform.position = handPoint.transform.position;
                other.transform.SetParent(handPoint.gameObject.transform);
                notPickingBox = false;
                dragSound.Play();

                
                }
               else
               {
                other.transform.SetParent(null);
                notPickingBox = true;
                
               }
                
            }

       



        }
        

        else if (other.transform.tag == "Minibox")
        {
            
            if (movementInput.x > 0 && DropBoxOnCollision.notOnCollision)
            {
                other.transform.position = handPoint1.transform.position;
                other.transform.SetParent(handPoint1.gameObject.transform);
                pickedObject = this.gameObject;
            }
            
            
            else

            {
                other.transform.SetParent(null);
                pickedObject = null;
            }
        }


      
    }



    public void Grab()
    {
       
    }
}
//other.GetComponent<Rigidbody2D>().isKinematic = true;
