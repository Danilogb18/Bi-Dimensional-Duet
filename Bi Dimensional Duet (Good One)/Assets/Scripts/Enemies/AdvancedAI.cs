using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvancedAI : MonoBehaviour
{

    public Transform cubitoTransform;
    public Transform trianguloTransform;
    public Transform pointToGoTransform;
    public Transform pointToGoTransform2;
    Vector2 initialPos;
    Vector2 cubitoPosition;
    Vector2 pointToGo;
    Vector2 pointToGo2;
    bool callCoroutine;
    public float speed;
    public Animator spriteAnim;
    bool canChangeState = true;
    private bool canDecidePoint;

    [SerializeField]
    bool isTheFlyer;


    public static bool firstAttack;
    public static bool shootAttack;
    public static bool fallingAttack;

    public static float pyramidLife = 20;
    public Slider lifeSlide;

    int rand;

    //things neededfor the cutscene here
    public PyramidDeathCutScene winScript;
    

    
    void Start()
    {
        callCoroutine = true;
        initialPos = new Vector2(transform.position.x, transform.position.y);
        pointToGo = pointToGoTransform.position;
        pointToGo2 = pointToGoTransform2.position;
        pyramidLife = 20;
    }

    private void Update()
    {
        if(canChangeState)
        {
        //StartCoroutine(ChangeState());
        }

        if (pyramidLife <= 0)
        {
            winScript.WinScene();
            Destroy(gameObject);
            
        }

        if (pyramidLife <= 10)
        {
            spriteAnim.SetTrigger("Enraged");
        }

        lifeSlide.value = pyramidLife;


        
    }
    void FixedUpdate()
    {
        if(firstAttack)
        {
        transform.position = Vector2.MoveTowards(transform.position, cubitoPosition, speed);
        spriteAnim.SetBool("Idle", true);
        spriteAnim.SetBool("Falling", false);
        spriteAnim.SetBool("Shooting", false);
        canDecidePoint = true;
        if (callCoroutine)
        {
        StartCoroutine("PlayerPosition");
        }
          
        }


        if(shootAttack)
        {
            if (canDecidePoint)
            {
                DecidePointToGo();
                canDecidePoint = false;
            }
            if (rand == 0)
            {
            transform.position = Vector2.MoveTowards(transform.position, pointToGo, 4 + speed);
            }
            else if (rand == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, pointToGo2, 4 + speed);
            }
            if(transform.position == pointToGoTransform.position || transform.position == pointToGoTransform2.position)
            {
            spriteAnim.SetBool("Idle", false);
            spriteAnim.SetBool("Falling", false);
            spriteAnim.SetBool("Shooting",true);
            }
        }

        if(fallingAttack)
        {
            spriteAnim.SetBool("Idle", false);
            spriteAnim.SetBool("Falling", true);
            spriteAnim.SetBool("Shooting",false);
            canDecidePoint = true;

            // if (callCoroutine)
            // {
            // callCoroutine = false;
            // StartCoroutine("FallingAttack");
            // }

        }


        if (isTheFlyer)
        {
            if (ChangePlayer.cubitoActive)
            {
                if (transform.position.x < cubitoTransform.position.x)
                {
                    transform.eulerAngles = new Vector3(0,0, -10);
                }

                else if(transform.position.x > cubitoTransform.position.x)
                {
                    transform.eulerAngles = new Vector3(0,0, 10);
                }

                else if (transform.position.x == cubitoTransform.position.x)
                {
                    transform.eulerAngles = new Vector3(0,0, 0);
                }
            }
        }
    }


    IEnumerator PlayerPosition()
    {
        callCoroutine = false;
        if (ChangePlayer.cubitoActive)
        {
        cubitoPosition = new Vector2(cubitoTransform.position.x, Random.Range(initialPos.y -20, initialPos.y + 10));
        
        }

        else
        {
            cubitoPosition = new Vector2(trianguloTransform.position.x, Random.Range(initialPos.y -20, initialPos.y + 10));
            
        }
        yield return new WaitForSeconds(0.1f);
        callCoroutine = true;
    }

    IEnumerator ChangeState()
    {
        int timeBetween;
        int state;

        timeBetween = Random.Range(6,8);
        state = Random.Range(0,3);

        if(state == 0)
        {
            firstAttack = true;
            shootAttack = false;
            fallingAttack = false;
        }

        else if (state == 1)
        {
            firstAttack = false;
            shootAttack = true;
            fallingAttack = false;
        }

        else if (state == 2)
        {
            fallingAttack = true;
            firstAttack = false;
            shootAttack = false;
        }

        canChangeState = false;
        Debug.Log("Cambio");
        yield return new WaitForSeconds(timeBetween);
        canChangeState = true;
    }


    void DecidePointToGo ()
    {
       rand = Random.Range(0,2);
       canDecidePoint = false;
    }


    IEnumerator FallingAttack()
    {
        Vector3 pointToGoBack;
        pointToGoBack = transform.position;

        transform.position = Vector2.MoveTowards(transform.position, cubitoPosition, speed);
        yield return new WaitForSeconds(2);
        transform.position = Vector2.MoveTowards(transform.position, new Vector3(transform.position.x, -405, 0), speed + 10);
        yield return new WaitForSeconds (1);
        transform.position = Vector2.MoveTowards(transform.position, pointToGoBack, speed + 10);
        Debug.Log("FallingAttack");
        callCoroutine = true;

        


    }

}
