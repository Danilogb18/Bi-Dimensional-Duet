using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CutScene1 : MonoBehaviour
{
    public Animator camAnimator;
    NewControls newControls;
    public GameObject[] VerticesForCurScene;
    public AudioSource discoverSound;


    private void Start()
    {
        newControls = GameObject.FindGameObjectWithTag("Player").GetComponent<NewControls>();
    }


    private void Update()
    {
        if(ChangePlayer.cubitoActive)
        {
            camAnimator.SetBool("cubitoActive", true);
        }
        else
        {
            camAnimator.SetBool("cubitoActive", false);
        }
    }


   // private void OnTriggerEnter2D(Collider2D other)
  //  {
        //if (other.transform.tag == "Player" && Vertices.pickedVertices == 4 && Vertices.readyForCutScene)
        //{
        //    NewControls.canPlay = false;
        //    camAnimator.SetBool("CutScene1", true);
       //     StartCoroutine(StartCutScene());
     //   }
   // }

    public void CutSceneKey()
    {
        NewControls.canPlay = false;
        DamageObject.vulnerable = false;
        camAnimator.SetBool("CutScene1", true);
        StartCoroutine(StartCutScene());
    }




    IEnumerator StartCutScene()
    {
           yield return new WaitForSeconds (3);
           newControls.ShowKey();
           DamageObject.vulnerable = false;
           yield return new WaitForSeconds (1);
           discoverSound.Play();
           yield return new WaitForSeconds (3.5f);
           camAnimator.SetBool("CutScene1", false);
           yield return new WaitForSeconds (1.5f);
           Destroy(VerticesForCurScene[0]);
           Destroy(VerticesForCurScene[1]);
           Destroy(VerticesForCurScene[2]);
           NewControls.canPlay = true;
           DamageObject.vulnerable = true;
          
           
    }
}
