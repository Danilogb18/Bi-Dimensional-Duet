using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OpenDoor : MonoBehaviour
{
    public GameObject doorMessage;
    public GameObject key;
    public GameObject bossSlider;
    private Animator animator;
    public Animator camaraAnimator;
    public AudioSource doorSound;
    public AudioSource winSound;
    public AudioSource bossMusic;
    public AudioSource discoverSound;

    bool haveOpenedTheDoor = false;

    
    PanelManager panelmanager;

    void Start()
    {
         panelmanager = GameObject.FindGameObjectWithTag("PlayerInteractionZone").GetComponent<PanelManager>();
        animator = this.GetComponent<Animator>();
        camaraAnimator.SetBool("winScene", false);
    }

    
    void Update()
    {
    


    }


    public void WinScene()
    {
        bossMusic.Stop();
        NewControls.canPlay = false;
        winSound.Play();
        StartCoroutine(WinCutScene());
    }

    


    public void OpenTheDoor()
    {
        if (GetKey.gotKey && PanelManager.nearDoor && haveOpenedTheDoor == false)
        {
                
            animator.SetBool("open", true);
            key.SetActive(false);
            Destroy(doorMessage);
            doorSound.Play();
            haveOpenedTheDoor = true;
            Debug.Log("seabrepuerta");
            // la instruccion para cerrar la puerta al entrar en commbate esta en newControls
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && haveOpenedTheDoor == false)
        {    
        
        panelmanager.ShowDoorMessage();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && haveOpenedTheDoor == false)
        {  
        
        panelmanager.ReturnShowDoorMessage();
        }
    }

    IEnumerator WinCutScene()
    {
        yield return new WaitForSeconds(2);
        camaraAnimator.SetBool("winScene", true);
        yield return new WaitForSeconds (2);
        animator.SetBool("open", true);
        yield return new WaitForSeconds(2);
        discoverSound.Play();
        yield return new WaitForSeconds(2);
        camaraAnimator.SetBool("winScene", false);
        NewControls.canPlay = true;
        bossSlider.SetActive(false);
    }
}
