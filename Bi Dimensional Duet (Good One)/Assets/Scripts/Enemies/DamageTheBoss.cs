using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTheBoss : MonoBehaviour
{
   private bool bossVulnerable = true;


    public Renderer rend;

    public Color colorToChange;

    public Color initialColor;
    

    void Start()
    {
        initialColor = rend.material.color;
    }

   
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "Boss" && bossVulnerable)
        {
        bossVulnerable = false;
        Boss.bossLife = Boss.bossLife-3;
        rend.material.color = colorToChange;
        StartCoroutine(NormalColor());
        StartCoroutine((makeBossVulnerable()));    
   
        }
    }


    IEnumerator makeBossVulnerable()
    {
        yield return new WaitForSeconds (5);
        bossVulnerable = true;
        //Debug.Log(Boss.bossLife);
        //CheckGround.canJump = true;
        //animator.SetBool("jumping", false);
    }


    IEnumerator NormalColor()
    {
        yield return new WaitForSeconds(0.7f);
        rend.material.color = initialColor;
    }
}
