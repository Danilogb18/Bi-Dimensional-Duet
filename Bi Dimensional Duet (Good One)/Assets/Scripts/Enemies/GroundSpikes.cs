using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpikes : MonoBehaviour
{
    public GameObject explosionContainer;
    public GameObject preExplosionContainer;
    public GameObject[] allSpikes;
    public GameObject allContainer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExplosionParticles()
    {
       preExplosionContainer.SetActive(false);
       explosionContainer.SetActive(true);
    }

    public void PreExplosionParticles()
    {
      

        preExplosionContainer.SetActive(true);
        explosionContainer.SetActive(false);
        foreach (GameObject s in allSpikes)
        {
            s.SetActive(true);
        }

        allContainer.transform.Translate(new Vector3(Random.Range(-10,11), 0,0));
        


        

    }

    public void FinishAnimation()
    {
        preExplosionContainer.SetActive(false);
        //explosionContainer.SetActive(false);
        foreach (GameObject g in allSpikes)
        {
            g.SetActive(false);
        }
    }

}
