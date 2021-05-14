using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotEnoughVertices : MonoBehaviour
{
    public GameObject notEnoughVerticesMessage;
    public static bool enoughVertices;

    void Start()
    {
        enoughVertices = false;
        if (VerticesLevel2.pickedVertices >= 8)
        {
            enoughVertices = true;
        }
    }

    
    void Update()
    {
        if (VerticesLevel2.pickedVertices < 8)
        {
            enoughVertices = false;
        }

        if (VerticesLevel2.pickedVertices == 8)
        {
            enoughVertices = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && VerticesLevel2.pickedVertices < 8)
        {
            notEnoughVerticesMessage.SetActive(true);
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        notEnoughVerticesMessage.SetActive(false);
    }


}
