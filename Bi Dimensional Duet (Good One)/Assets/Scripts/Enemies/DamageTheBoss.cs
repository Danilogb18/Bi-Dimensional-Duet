using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTheBoss : MonoBehaviour
{
   private bool bossVulnerable = true;
    

    void Start()
    {
        
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
}
