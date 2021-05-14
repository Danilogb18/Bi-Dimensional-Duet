using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageThePyramid : MonoBehaviour
{
    private bool bossVulnerable = true;
    

    void Start()
    {
        bossVulnerable = true;
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.tag == "chainsaw")
        {
            {
                AdvancedAI.pyramidLife = AdvancedAI.pyramidLife-2.3f;
            }
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
