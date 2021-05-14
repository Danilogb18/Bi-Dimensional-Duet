using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChainSawSound : MonoBehaviour
{
    [SerializeField]
    bool veryClose;

    [SerializeField]
    bool far;

    [SerializeField]
    bool reallyFar;


    public AudioSource sound;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
              StopAllCoroutines();
              StopCoroutine("FadeOutVolumeFar");
              if(veryClose)
              {
                  
                  sound.volume = 1;
              }
        
              else if (far)
              {
                  
                  StartCoroutine("FadeInVolumeFar");
              }
        
               else if(reallyFar)
              {
                  
                  sound.Play();
                  StartCoroutine("FadeInVolumeReallyFar");
                  
              }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            StopAllCoroutines(); 
            if(veryClose)
              {
                  
                  sound.volume = 0.6f;
              }
        
              else if (far)
              {
                  
                  StartCoroutine("FadeOutVolumeFar");
              }
        
               else if(reallyFar)
              {
                
                  StartCoroutine("FadeOutVolumeReallyFar");
              }
        }
    }


    IEnumerator FadeOutVolumeReallyFar()
    {
        sound.volume = 0.2f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.15f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.1f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.05f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0;
        yield return new WaitForSeconds(0.3f);
        sound.Stop();
    }
    
    IEnumerator FadeInVolumeReallyFar()
    {
        sound.volume = 0.05f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.1f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.15f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.2f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.25f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.3f;
    }





       IEnumerator FadeOutVolumeFar()
    {
        sound.volume = 0.55f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.50f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.45f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.35f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.3f;
        yield return new WaitForSeconds(0.3f);
        
    }
    
    IEnumerator FadeInVolumeFar()
    {
        sound.volume = 0.35f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.4f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.45f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.5f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.55f;
        yield return new WaitForSeconds(0.3f);
        sound.volume = 0.6f;
    }


}
