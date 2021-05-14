using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterPortal : MonoBehaviour
{
    public GameObject winMessage;
    public Animator exitPanelAnim;
    private bool nearPortal = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && PlayerPrefs.GetInt("ActualLevel") == 1)
        {
            ShowWinMessage();
            nearPortal = true;
        }

        else if (other.transform.tag == "Player" && PlayerPrefs.GetInt("ActualLevel") == 2)
        {
            if (NotEnoughVertices.enoughVertices)
            {
                nearPortal = true;
                ShowWinMessage();
            }
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            ReturnWinMessage();
            nearPortal = false;
        }
    }


    public void ShowWinMessage()
    {
        winMessage.SetActive(true);
    }

    public void ReturnWinMessage()
    {
        winMessage.SetActive(false);
    }

    public void Win(string scene)
    {
        if (nearPortal)
        {        
        NewControls.enteredBossZone = false;
        StartCoroutine(WinScene(scene)); 
        }
    }

    IEnumerator WinScene(string scene)
    {
      exitPanelAnim.SetTrigger("finishlevel");
      yield return new WaitForSeconds (2);
      SceneManager.LoadScene(scene);
    }
}
