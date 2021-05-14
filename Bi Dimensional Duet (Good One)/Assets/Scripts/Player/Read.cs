using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Read : MonoBehaviour
{
    public GameObject readMessage;
    public GameObject readPanel;
    private bool canRead;
    private bool reading;
    public Transform allReads ;
    public int readsNumber;
    private int index = 0;
    private bool canCall = true;


    void Start()
    {
        readMessage.SetActive(false);
        readPanel.SetActive(false);
        canRead = false;
        reading = false;

    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            readMessage.SetActive(true);
            canRead = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            readMessage.SetActive(false);   
            canRead = false;
        }
    }

    public void ReadStuff()  
    {
        if(canRead)
        {
            readPanel.SetActive(true);
            readMessage.SetActive(false);
            NewControls.canPlay = false;
            reading = true;
            PanelManager.canPause = false;
            
            
        }
    }

    public void ReturnRead()
    {
        if (canCall)
        {
        canCall = false;
        StartCoroutine("CanCall");
        index = 0;

        for (int i = 0; i < readsNumber; i++)
        {
            if(allReads.GetChild(index).gameObject.activeSelf)
            {reading = true;
            }
            allReads.GetChild(index).gameObject.SetActive(false);
            index++;
        
        }
        if(reading)
        {
            readPanel.SetActive(false);
            NewControls.canPlay = true;
            reading = false;
            PanelManager.canPause = true;

          
            
        }

        }
                
    }




    IEnumerator CanCall()
    {
        yield return new WaitForSeconds(1);
        canCall = true;
    }
}
