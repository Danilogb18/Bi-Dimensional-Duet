using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public static bool isPaused = false;
    public Animator exitPanelAnim;
    public AudioSource press;
    public Animator soundButton;

    public AudioListener audioListener;

    public AudioSource mainMusic;
    public AudioSource bossMusic;
    public AudioSource hosueMusic; // En las escenas donde no hayan casas solo pon cualquier sonido. Creo que no afectara.
    public AudioSource jumpSound;
    public AudioSource jumpSoundTriangulo;

    public static bool audioActivated = true;

    public GameObject [] sonidos;

    void Start()
    {
        soundButton.SetBool("audioActivated", true);
    }

    
    void FixedUpdate()
    {
       
    }


    public void PauseGame()
    {
        if(PanelManager.canPause)
        {
        press.Play();
        
        if (isPaused)
        {
            pausePanel.SetActive(false);
            isPaused = false;
            NewControls.canPlay = true;
            if (audioActivated)
            {
            mainMusic.UnPause();
            bossMusic.UnPause();
            hosueMusic.UnPause();
            }
            Time.timeScale = 1;
        }

        else
        {
        NewControls.canPlay = false;    
        isPaused = true;
        pausePanel.SetActive(true);

        if(audioActivated){
        mainMusic.Pause();
        bossMusic.Pause();
        hosueMusic.Pause();
        }
        
        Time.timeScale = 0;

        
        }
        }
        
    }


    public void ContinueGame()
    {
        press.Play();
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        NewControls.canPlay = true;
        isPaused = false;
        if (audioActivated)
        {
        mainMusic.UnPause();
        bossMusic.UnPause();
        hosueMusic.UnPause();
        }
    }



    public void LoadScene(string scene)
    {
      press.Play();
      Time.timeScale = 1;
      StartCoroutine(ChangeScene(scene));  
    }


     IEnumerator ChangeScene(string scene)
     {
      
      exitPanelAnim.SetTrigger("finishlevel");
      yield return new WaitForSeconds (2);
      SceneManager.LoadScene(scene);
     }


     public void QuitGame()
     {
         
         Application.Quit();
     }

     public void DeactivateAudio()
     {
        if(audioActivated)
        {
            audioActivated = false;
          //  bossMusic.Pause();
         //   mainMusic.Pause();
            //jumpSound.enabled = false;
           // jumpSoundTriangulo.enabled = false;
            soundButton.SetBool("audioActivated", false);
            press.Play();

            AudioListener.volume = 0f;

            

           // foreach (GameObject a in sonidos)
           // {
              //  a.SetActive(false);
        //    }
            
        }

        else
        {
            audioActivated = true;
           // bossMusic.UnPause();
           // mainMusic.UnPause();
           // jumpSound.enabled = true;
          //  jumpSoundTriangulo.enabled = true;
            soundButton.SetBool("audioActivated", true);
            press.Play();

           AudioListener.volume = 1f;

          //  foreach (GameObject a in sonidos)
         //   {
            //    a.SetActive(true);
        //    }
            
        }
     }
}
