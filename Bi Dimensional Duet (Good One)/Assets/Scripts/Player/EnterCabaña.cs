using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnterCabaña : MonoBehaviour
{
    public GameObject enterMessage;
    private bool canEnter;
    public Animator camaras;
    public Transform cubitoPosition;
    public Transform trianguloPosition;
    public Animator fadeOutPanel;
    public Transform doorToGo;
    private bool inCabaña;
    public AudioSource houseMusic;
    public AudioSource mainMusic;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            enterMessage.SetActive(true);
            canEnter = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            enterMessage.SetActive(false);
            canEnter = false;
        }
    }



    public void EnterCabaña()
    {
        if(NewControls.canPlay){

        if(canEnter)
        {
            NewControls.canPlay = false;
             StartCoroutine(GoToTheCabaña());
             
             
        }
             
        }
    }

     IEnumerator GoToTheCabaña()
    {

            fadeOutPanel.SetBool("makeFinish", true);
            yield return new WaitForSeconds(2);
            camaras.SetBool("CutScene1", true);
            cubitoPosition.position = doorToGo.position;
            trianguloPosition.position = doorToGo.position;
            mainMusic.Stop();
            yield return new WaitForSeconds(3);
            fadeOutPanel.SetBool("makeFinish", false);
            NewControls.canPlay = true;
            houseMusic.Play();

            
        
       
    }
}
