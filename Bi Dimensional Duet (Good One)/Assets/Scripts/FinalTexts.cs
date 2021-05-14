using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTexts : MonoBehaviour
{
    public Animator firstText;
    public Animator secondText;
    public Animator thirdText;
    public Animator theButton;

    public GameObject segundoTexto;
    public GameObject boton;

    private bool finishedThanks;
    void Start()
    {
        segundoTexto.SetActive(false);
        StartCoroutine (ShowTexts());
        boton.SetActive(false);
        finishedThanks = false;
    }

    
    void Update()
    {
        
    }


    IEnumerator ShowTexts()
    {
        yield return new WaitForSeconds(3);
        firstText.SetTrigger("primertexto");
        yield return new WaitForSeconds(2);
        segundoTexto.SetActive(true);
        secondText.SetTrigger("segundotexto");
        yield return new WaitForSeconds(2);
        thirdText.SetTrigger("tercertexto");
        yield return new WaitForSeconds(2);
        boton.SetActive(true);
        theButton.SetTrigger("showBoton");
        finishedThanks = true;

    }


    public void GoToMenu (string scene)
    {
        if (finishedThanks)
        {
        SceneManager.LoadScene(scene);
        }
    }
    
}

