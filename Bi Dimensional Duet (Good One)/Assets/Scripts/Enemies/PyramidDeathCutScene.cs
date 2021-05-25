using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidDeathCutScene : MonoBehaviour
{
    
    public Animator cameraControlerAnim;
    public GameObject platform;
    public GameObject pyramidChainsaw;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void WinScene()
    {
       NewControls.canPlay = false;
       Destroy(pyramidChainsaw);
       cameraControlerAnim.SetBool("winScene", true);
       StartCoroutine(WinSceneCorroutine());
    }


    IEnumerator WinSceneCorroutine()
    {
        yield return new WaitForSeconds(3.5f);
        platform.SetActive(true);
        yield return new WaitForSeconds(2);
        NewControls.canPlay = true;
        cameraControlerAnim.SetBool("winScene", false);

    }
}
