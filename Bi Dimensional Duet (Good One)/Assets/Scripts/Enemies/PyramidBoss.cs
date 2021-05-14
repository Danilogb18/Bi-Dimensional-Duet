using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidBoss : MonoBehaviour
{
    private Vector2 actualPos;
    public Transform cubitoTransform;
    public Transform triangulitoTransform;
    

    void Start()
    {
        
    }


    void Update()
    {
        //StartCoroutine(checkDirection());
        if (ChangePlayer.cubitoActive)
        {
        if (cubitoTransform.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        else if (cubitoTransform.position.x > transform.position.x)
        {
           transform.localScale = new Vector3(1,1,1);
        }
        }

        else
        {
            if (triangulitoTransform.position.x < transform.position.x)
            {
               transform.localScale = new Vector3(-1,1,1);
            }

            else if (triangulitoTransform.position.x > transform.position.x)
            {
               transform.localScale = new Vector3(1,1,1);
            }
        }
    }

     IEnumerator checkDirection()
    {
        actualPos = transform.position;


        yield return new WaitForSeconds(0.5f);

        if (transform.position.x > actualPos.x)
        {
            //spriteRenderer.flipX = false;
            transform.localScale = new Vector3(1,1,1);
        }

        else if (transform.position.x < actualPos.x)
        {
           //spriteRenderer.flipX = true;
           transform.localScale = new Vector3(-1,1,1);
        }
    }
}
