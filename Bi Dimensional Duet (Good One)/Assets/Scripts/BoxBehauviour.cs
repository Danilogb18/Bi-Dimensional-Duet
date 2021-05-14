using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehauviour : MonoBehaviour
{
    public Transform miniBoxPosition;
    public Transform handPointBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag != "PlayerInteractionZone")
        {
            gameObject.transform.SetParent(null);
        }

        else if (other.transform.tag == "PlayerInteractionZone")
        {
            gameObject.transform.position = miniBoxPosition.position;
            gameObject.transform.SetParent(handPointBox);
        }
    }
}
