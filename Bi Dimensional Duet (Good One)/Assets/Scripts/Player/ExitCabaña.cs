using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ExitCabaña : MonoBehaviour
{
    public GameObject enterMessage;
    private bool canEnter;
    public Animator camaras;
    public Transform cubitoPosition;
    public Transform trianguloPosition;
    public Animator fadeOutPanel;
    public Transform doorToGo;
    private bool inCabaña;
    public AudioSource mainMusic;
    public AudioSource houseMusic;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            enterMessage.SetActive(true);
            canEnter = true;
            Debug.Log("indoor");
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



    public void ExitTheCabaña()
    {
        if (NewControls.canPlay){

        if(canEnter)
        {
            NewControls.canPlay = false;
             StartCoroutine(ExitCabaña());
             
             
        }
             
        }
    }

     IEnumerator ExitCabaña()
    {
            fadeOutPanel.SetBool("makeFinish", true);
            yield return new WaitForSeconds(2);
            houseMusic.Stop();
            camaras.SetBool("CutScene1", false);
            cubitoPosition.position = doorToGo.position;
            trianguloPosition.position = doorToGo.position;
            yield return new WaitForSeconds(3);
            fadeOutPanel.SetBool("makeFinish", false);
            NewControls.canPlay = true;
            mainMusic.Play();
       
    }
}
