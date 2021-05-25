using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private Renderer rend;


    [SerializeField]
    private Color hitColor;


    [SerializeField]
    private Color initialColor;



    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        initialColor = rend.material.color;
    }

    
    void Update()
    {
        
    }


    public void ChangeToHitColor()
    {
        rend.material.color = hitColor;
        StartCoroutine(NormalColor());
    }


    IEnumerator NormalColor()
    {
        yield return new WaitForSeconds(0.7f);
        rend.material.color = initialColor;

    }




}
