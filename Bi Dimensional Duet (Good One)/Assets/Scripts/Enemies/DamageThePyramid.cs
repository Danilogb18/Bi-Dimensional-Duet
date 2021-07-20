using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DamageThePyramid : MonoBehaviour
{
    private bool bossVulnerable = true;
    private ChangeColor changeColorScript;

    public Transform impactPoint;
    public GameObject particles;
    public AudioSource hitSound;

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
                hitSound.Play();
                AdvancedAI.pyramidLife = AdvancedAI.pyramidLife-20f;
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