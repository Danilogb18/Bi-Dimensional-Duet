using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossZone : MonoBehaviour 
{
    public GameObject bossSlider;
    public GameObject boss;
    public GameObject pyramidChainsaw;

    public Animator bossName;

    void Start()
    {
        // este scripts esta en el objeto marcado como bosszone, no en el jugador
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            bossSlider.SetActive(true);
            bossName.SetBool("ShowBossName", true);
            boss.SetActive(true);
            pyramidChainsaw.SetActive(true);
            Destroy(gameObject);
            
        }
    }
}
