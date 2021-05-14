using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public Transform playerPos;
    public Transform playerPos2;
    public float speed;
    private Vector2 actualPos;
    public Transform bossScale;
    public Transform bossSon;
    public Animator animator;
    private bool inGround = false;
    public static int bossLife;
    public Slider bossHealthBar;
    private float timeForGround;
    OpenDoor openDoor;

    public static bool bossDefeated;
    
    
    void Start()
    {
        bossDefeated = false;
        bossLife = 20;
        timeForGround = 0.5f;
        openDoor = GameObject.FindGameObjectWithTag("Finish").GetComponent<OpenDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        bossHealthBar.value = bossLife;
        StartCoroutine(checkDirection());
       
        Vector2 target = new Vector2(playerPos.position.x, gameObject.transform.position.y);
        Vector2 target2 = new Vector2(playerPos2.position.x, gameObject.transform.position.y);

        if (ChangePlayer.cubitoActive)
        {           
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target, speed * Time.deltaTime);
        }
        else
        {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target2, speed * Time.deltaTime);
        }

        if (bossLife <= 10)
        {
            animator.SetTrigger("angry");
            speed = 40;
            timeForGround = 0.6f;
        }

        if (bossLife <= 0)
        {
            openDoor.WinScene();
            bossDefeated = true;
            Destroy(gameObject, 0.1f);
        }

    }


     IEnumerator checkDirection()
    {
        actualPos = transform.position;


        yield return new WaitForSeconds(0.5f);

        if (transform.position.x > actualPos.x && inGround)
        {
            //spriteRenderer.flipX = false;
            bossScale.localScale = new Vector3(-1,1,1);
        }

        else if (transform.position.x < actualPos.x && inGround)
        {
           //spriteRenderer.flipX = true;
           bossScale.localScale = new Vector3(1,1,1);
        }
    }
// && bossSon.position.y <= 0)

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "ground")
        {
            StartCoroutine(MakeInGround());
        }
        
        if (other.transform.tag == "Player" && CheckGround.canJump)
        {
            animator.SetBool("jumping", true);
        }


        if (other.transform.tag == "spikeenemy")
        {
            animator.SetBool("jumping", true);
        }

        
    }

    void OnTriggerStay2D(Collider2D other)
    {
         if (other.transform.tag != "ground")
        {
            inGround = false;
        }
    }


    IEnumerator MakeInGround()
    {
        yield return new WaitForSeconds(timeForGround);
        inGround = true;
    }
}
