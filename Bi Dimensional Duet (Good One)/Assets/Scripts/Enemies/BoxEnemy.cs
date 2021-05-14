using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnemy : MonoBehaviour
{
    public Animator animator;
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


}