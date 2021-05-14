using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour // en este script no estan todos los mensajes y paneles. El de entrar a la cabaña por ejemplo esta en entercabaña.
{
    public GameObject boxMessage;
    public GameObject verticeMessage;
    public GameObject changeMessage;
    public GameObject changeAnalisisMessage;
    public GameObject changeAnalisisPanel;
    private bool isAnalyzing;
    public GameObject doorMessage;
    public static bool nearDoor;
    public static bool canPause = true;
    public GameObject bossAdvicePanel;


    private bool onVerticeMessage = false;
    private bool analingPanel = false;

    void Start()
    {
        changeMessage.SetActive(false);
        isAnalyzing = false;
    }

    
    void Update()
    {
        
    }

    public void Boxes()
    {
        boxMessage.SetActive(true);
    }

    public void NoBoxes()
    {
        boxMessage.SetActive(false);
    }



    public void VerticeMessage()
    {
        onVerticeMessage = true;
        NewControls.canPlay = false;
        verticeMessage.SetActive(true);
        canPause = false;
    }
    
    public void ReturnVerticeMessage()
    {
        if (onVerticeMessage)
        {
        NewControls.canPlay = true;
        verticeMessage.SetActive(false);
        changeAnalisisPanel.SetActive(false);
        canPause = true;
        }
    }



    public void ChangeMessage()
    {
       changeMessage.SetActive(true);
    }

    public void ReturnChangeMessage()
    {
       changeMessage.SetActive(false);
    }




    public void ChangeAnalisis() // mostrar el mensaje para analizar
    {
    changeAnalisisMessage.SetActive(true);
    isAnalyzing = true;
    }


    public void ReturnChangeAnalisis()  // sacar el mensaje para analizar 
    {
       changeAnalisisMessage.SetActive(false);
       isAnalyzing = false;
    }


    public void ShowChangeAnalisis() // mostrar el panel donde ya analiza
    {

       if (isAnalyzing && PauseMenu.isPaused == false)
       {         
       changeAnalisisPanel.SetActive(true);
       NewControls.canPlay = false;
       analingPanel = true;
       canPause = false;

       

       } 
    }

    public void ReturnChangeAnalisisPanel()
    {
        if(analingPanel){
        changeAnalisisPanel.SetActive(false);
        NewControls.canPlay = true;
        analingPanel = false;
        canPause = true;
        }
    }


    public void ShowDoorMessage()
    {
      nearDoor = true;
      doorMessage.SetActive(true);

    }

        public void ReturnShowDoorMessage()
    {
      nearDoor = false;
      doorMessage.SetActive(false);
    }



    public void ReturnBossAdvice()
    {
        //aparece en changeplayer al cargar la partida. por si acaso
        
        bossAdvicePanel.SetActive(false);
        if(NewControls.enteredBossZone)
        {
        NewControls.canPlay = true;
        }
    }
}
