using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformIA : MonoBehaviour
{
    public GameObject cubito;
    public GameObject triangulito;
    GameObject minibox;
    public float speed =0.5f;
    public Transform [] wayPoint;
    private float waitTime;
    public float startWaitTime;
    private int i = 0;
    private Vector2 actualPos;




    void Start()
    {
        waitTime = startWaitTime;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint[i].transform.position, speed * Time.deltaTime);
        

        if (Vector2.Distance(transform.position,wayPoint[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                if (wayPoint[i] != wayPoint[wayPoint.Length-1])
                {
                    i++;
                    
                }

                else
                {
                    i = 0;
                   
                }

                waitTime = startWaitTime;
            }

            else
            {
               
                waitTime -= Time.deltaTime;
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            cubito.transform.SetParent(this.gameObject.transform);
            triangulito.transform.SetParent(this.gameObject.transform);
        }



    
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.tag == "Minibox")
        {
           minibox = other.gameObject;
           minibox.transform.SetParent(this.gameObject.transform);
           
        }

        
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Minibox")
        {
            minibox.transform.SetParent(null);
            minibox = null;
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        
            //Debug.Log("volando");
            cubito.transform.SetParent(null);
            triangulito.transform.SetParent(null);
            
    }
}
