using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedAIDeath : MonoBehaviour
{
    [SerializeField]
    int enemyLife;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (enemyLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "BreakBox")
        {
            enemyLife--;
        }
    }
}
