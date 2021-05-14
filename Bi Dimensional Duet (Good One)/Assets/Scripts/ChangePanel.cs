using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    PanelManager panelmanager;

    void Start()
    {
         panelmanager = GameObject.FindGameObjectWithTag("PlayerInteractionZone").GetComponent<PanelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            panelmanager.ChangeAnalisis();
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            panelmanager.ReturnChangeAnalisis();
        }
    }

    
}
