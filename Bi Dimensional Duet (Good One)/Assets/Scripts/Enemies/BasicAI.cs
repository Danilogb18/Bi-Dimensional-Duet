using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public float speed =0.5f;
    public Transform [] wayPoint;
    private float waitTime;
    public float startWaitTime;
    private int i = 0;
    private Vector2 actualPos;
    float scaleOfEnemy;
    float initialScaleOfEnemy;




    void Start()
    {
        waitTime = startWaitTime;
        initialScaleOfEnemy = transform.localScale.x;

    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(checkDirection());
        transform.position = Vector2.MoveTowards(transform.position, wayPoint[i].transform.position, speed * Time.deltaTime);
        

        if (Vector2.Distance(transform.position,wayPoint[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                if (wayPoint[i] != wayPoint[wayPoint.Length-1])
                {
                    i++;
                    animator.SetBool("Idle", false);
                }

                else
                {
                    i = 0;
                    animator.SetBool("Idle", false);
                }

                waitTime = startWaitTime;
            }

            else
            {
                animator.SetBool("Idle", true);
                waitTime -= Time.deltaTime;
            }
        }
        
    }


    IEnumerator checkDirection()
    {
        actualPos = transform.position;
        scaleOfEnemy = initialScaleOfEnemy;
        

        yield return new WaitForSeconds(0.5f);

        if (transform.position.x > actualPos.x)
        {
           // spriteRenderer.flipX = false;
            transform.localScale = new Vector3(initialScaleOfEnemy, transform.localScale.y, transform.localScale.z);
        }

        else if (transform.position.x < actualPos.x)
        {
           //spriteRenderer.flipX = true;
           transform.localScale = new Vector3(-initialScaleOfEnemy, transform.localScale.y, transform.localScale.z);
        }
    }
}
