using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class DamageObject : MonoBehaviour
{
    public static int life;
    public static bool vulnerable;
    public Animator animator;
    public Animator animatorTriangulo;
    public AudioSource hitSound;

    void Start()
    {
       life = 3;
       vulnerable = true;
       
    }

    // Update is called once per frame
    void Update()
    {
      //Debug.Log(life);
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && vulnerable)
        {
        vulnerable = false;
        life--;
        StartCoroutine((makeVulnerable()));    
        animator.SetTrigger("hitted");
        animatorTriangulo.SetTrigger("hitted");
        hitSound.Play();
        }
    }


    IEnumerator makeVulnerable()
    {
        yield return new WaitForSeconds (2);
        vulnerable = true;
        //CheckGround.canJump = true;
        //animator.SetBool("jumping", false);
    }
}
