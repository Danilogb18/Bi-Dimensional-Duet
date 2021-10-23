using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MenuManager : MonoBehaviour
{
    public Animator[] anim;
    public static bool deactivate;
    public static bool activate;

    public GameObject creditPanel;
    public GameObject deleteWarning;
    public GameObject alreadyDeleted;


    private bool canStart;

    public AudioSource buttonSound;
    public AudioSource mainMusic;


  
    void Awake()
    {
        if (PlayerPrefs.GetInt("ActualLevel") == 1)
        {
          PlayerPrefs.SetInt("ActualLevel", 1);
        }

        else if (PlayerPrefs.GetInt("ActualLevel") == 2)
        {
          PlayerPrefs.SetInt("ActualLevel", 2);
        }

        else if (PlayerPrefs.GetInt("ActualLevel") == 3)
        {
          PlayerPrefs.SetInt("ActualLevel", 3);
        }

        else 
        {
           PlayerPrefs.SetInt("ActualLevel", 0);
        }

        

    }

    void Start()
    {
        canStart = true;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        //Screen.SetResolution(1920, 1080, true);
      
    }

    public void LoadScene(string scene)
    {
      if (canStart)
      {
      StartCoroutine(Transiciona(scene)); 
      buttonSound.Play();
          
      }
      
      
      
    }



    IEnumerator Transiciona(string scene)
     {
    
      
      anim[0].SetTrigger("exit");
      yield return new WaitForSeconds (2);
       if (PlayerPrefs.GetInt("ActualLevel") == 0)
      {
          SceneManager.LoadScene("Inicio");
      }

      else if (PlayerPrefs.GetInt("ActualLevel") == 1)
      {
          SceneManager.LoadScene("SampleScene");
      }

       else if (PlayerPrefs.GetInt("ActualLevel") == 2)
      {
          SceneManager.LoadScene("Level2");
      }

    
      
  

     }

     public void Credits()
     {
         canStart = false;
         creditPanel.SetActive(true);
          buttonSound.Play();
     }

     public void ReturnCredits()
     {
         canStart = true;
         creditPanel.SetActive(false);
         deleteWarning.SetActive(false);
         alreadyDeleted.SetActive(false);
          buttonSound.Play();
          mainMusic.UnPause();
     }


     public void ExitGame()
     {
       buttonSound.Play();
       Application.Quit();
     }

     public void ShowWarning()
     {
       buttonSound.Play();
       deleteWarning.SetActive(true);
       mainMusic.Pause();
       
     }

     public void ReturnDelete()
     {
       buttonSound.Play();
       deleteWarning.SetActive(false);
       alreadyDeleted.SetActive(false);
       mainMusic.UnPause();

     }

     public void Delete() 
     {
       buttonSound.Play();
       PlayerPrefs.DeleteAll();
       deleteWarning.SetActive(false);
       alreadyDeleted.SetActive(true);
     }

     

    
  
}
