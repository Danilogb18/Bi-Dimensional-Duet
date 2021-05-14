using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBoxOnCollision : MonoBehaviour
{
    public static bool notOnCollision;
    public GameObject miniBox;

    void Start()
    {
        notOnCollision = true;
    }

    
    void Update()
    {
        
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.tag == "ground")
        {
            miniBox.transform.SetParent(null);
            notOnCollision = false;
        }

        else
        {
            notOnCollision = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "ground")
        {
            notOnCollision = true;
        }
    }
}
