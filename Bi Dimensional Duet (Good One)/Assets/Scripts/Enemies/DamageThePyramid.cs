using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageThePyramid : MonoBehaviour
{
    private bool bossVulnerable = true;
    private ChangeColor changeColorScript;

    public Transform impactPoint;
    public GameObject particles;

    void Start()
    {
        bossVulnerable = true;
        changeColorScript = GetComponent<ChangeColor>();
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.tag == "chainsaw" && bossVulnerable)
        {
            {
                bossVulnerable = false;
                AdvancedAI.pyramidLife = AdvancedAI.pyramidLife-2.2f;
                Instantiate(particles, impactPoint.position, Quaternion.identity);
                changeColorScript.ChangeToHitColor();
                StartCoroutine(makeBossVulnerable());
            }
        }
    }


    IEnumerator makeBossVulnerable()
    {
        yield return new WaitForSeconds (2);
        bossVulnerable = true;
        //Debug.Log(Boss.bossLife);
        //CheckGround.canJump = true;
        //animator.SetBool("jumping", false);
    }
}