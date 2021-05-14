using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HistoryManager : MonoBehaviour
{
    public GameObject textOne;
    public GameObject textTwo;
    public GameObject textThree;
    public GameObject continueButton;
    public Animator animPanel;

    private bool finishedHistory;

    void Start()
    {
        finishedHistory = false;
        StartCoroutine (History());
    }

    
    void Update()
    {
        
    }


    IEnumerator History()
    {
        yield return new WaitForSeconds(2.5f);
        textOne.SetActive(true);
        yield return new WaitForSeconds(3);
        textTwo.SetActive(true);
        yield return new WaitForSeconds(3);
        textThree.SetActive(true);
        yield return new WaitForSeconds(3);
        continueButton.SetActive(true);
        finishedHistory = true;
    }



    public void GoToLevel (string scene)
    {
        if (finishedHistory)
        {
        StartCoroutine(Transicion(scene));
            
        }
        
    }


    IEnumerator Transicion(string scene)
    {
       animPanel.SetTrigger("finishHistory");
       yield return new WaitForSeconds(2);
       SceneManager.LoadScene(scene);
    }
    
}
