using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadManager : MonoBehaviour
{
    public Transform target1;
void Start() {
  

}

void LateUpdate() {
       
      

   gameObject.transform.position = target1.transform.position + new Vector3(0,0,62);



       } 
  }

