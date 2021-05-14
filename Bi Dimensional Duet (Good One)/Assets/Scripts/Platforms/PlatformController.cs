using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject activated;
    public GameObject notactivated;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckGround.platformController)
        {activated.gameObject.SetActive (true);
        notactivated.gameObject.SetActive (false);}



        else
        {activated.gameObject.SetActive (false);
        notactivated.gameObject.SetActive (true);}
    }
}
