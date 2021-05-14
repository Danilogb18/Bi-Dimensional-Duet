using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VerticesLevel2 : MonoBehaviour
{
    public GameObject[] vertices;
    public static int pickedVertices = 0;
    public Animator animator;
    PanelManager panelmanager;
    public AudioSource verticeSound;
    NewControls newControls;
    private GameObject thisVertice;
    public static bool readyForCutScene = false;
    CutScene1 cutSceneScript;
    public GameObject [] allVertices;

    
    void Start()
    {
        cutSceneScript = GameObject.Find("VerticesForCutScene1").GetComponent<CutScene1>();
        readyForCutScene = false; 
        panelmanager = GameObject.FindGameObjectWithTag("PlayerInteractionZone").GetComponent<PanelManager>();
        newControls = GameObject.FindGameObjectWithTag("Player").GetComponent<NewControls>();
        thisVertice = this.gameObject;

        if(PlayerPrefs.GetInt("Checkpoint") == 0)
        {
            //Debug.Log("se aparecen");
            PlayerPrefs.SetInt("Vertice1", 1);
            PlayerPrefs.SetInt("Vertice2", 1);
            PlayerPrefs.SetInt("Vertice3", 1);
            PlayerPrefs.SetInt("Vertice4", 1);
            PlayerPrefs.SetInt("Vertice5", 1);
            PlayerPrefs.SetInt("Vertice6", 1);
            PlayerPrefs.SetInt("Vertice7", 1);
            PlayerPrefs.SetInt("Vertice8", 1);
        }


        LoadVertices();
        pickedVertices = PlayerPrefs.GetInt("pickedVertices");
        ShowVertices();
    }

    
    void Update()
    {
     
    }


     private void OnTriggerEnter2D(Collider2D other)
     {
            if (other.transform.tag == "Player")
            {
               animator.SetTrigger("Picked");
               verticeSound.Play();
               StartCoroutine((DestroiVertice())); 
              
               
            }

     }



     void ShowVertices()
     {

       if (pickedVertices == 1)
       {
            
            vertices[0].gameObject.SetActive(true);
      
            // Debug.Log("1 vertices"); 
       }

       else if (pickedVertices == 2)
       {
            
            vertices[0].gameObject.SetActive(true);
            vertices[1].gameObject.SetActive(true);
            //verticeSound.Play();
            //Debug.Log("2 vertices");
       }

       else if (pickedVertices == 3)
       {
            
            vertices[0].gameObject.SetActive(true);
            vertices[1].gameObject.SetActive(true);
            vertices[2].gameObject.SetActive(true);
            //verticeSound.Play();
             Debug.Log("3 vertices");
       }

       else if (pickedVertices == 4)
       {
            
            
            vertices[0].gameObject.SetActive(true);
            vertices[1].gameObject.SetActive(true);
            vertices[2].gameObject.SetActive(true);
            vertices[3].gameObject.SetActive(true);
            //verticeSound.Play();
             
       }
       else if (pickedVertices == 5)
       {
            
            vertices[0].gameObject.SetActive(true);
            vertices[1].gameObject.SetActive(true);
            vertices[2].gameObject.SetActive(true);
            vertices[3].gameObject.SetActive(true);
            vertices[4].gameObject.SetActive(true);
            //verticeSound.Play();
             
       }

       else if (pickedVertices == 6)
       {
            
            vertices[0].gameObject.SetActive(true);
            vertices[1].gameObject.SetActive(true);
            vertices[2].gameObject.SetActive(true);
            vertices[3].gameObject.SetActive(true);
            vertices[4].gameObject.SetActive(true);
            vertices[5].gameObject.SetActive(true);
            //verticeSound.Play();
             
       }

       else if (pickedVertices == 7)
       {
            readyForCutScene = true;
            vertices[0].gameObject.SetActive(true);
            vertices[1].gameObject.SetActive(true);
            vertices[2].gameObject.SetActive(true);
            vertices[3].gameObject.SetActive(true);
            vertices[4].gameObject.SetActive(true);
            vertices[5].gameObject.SetActive(true);
            vertices[6].gameObject.SetActive(true);
            //verticeSound.Play();
             
       }

       else if (pickedVertices == 8)
       {
            
            vertices[0].gameObject.SetActive(true);
            vertices[1].gameObject.SetActive(true);
            vertices[2].gameObject.SetActive(true);
            vertices[3].gameObject.SetActive(true);
            vertices[4].gameObject.SetActive(true);
            vertices[5].gameObject.SetActive(true);
            vertices[6].gameObject.SetActive(true);
            vertices[7].gameObject.SetActive(true);
            if (readyForCutScene)
            {
              // cutSceneScript.CutSceneKey();
            }
            //verticeSound.Play();
            
            

             //Debug.Log("4 vertices");
       }
     }


     IEnumerator DestroiVertice()
     {
          yield return new WaitForSeconds(0.5f);
          //Destroy(this.gameObject);
          thisVertice.SetActive(false);
          pickedVertices++;
          ShowVertices();
         
     }


     public void SaveVertices()
     {
          //InfoGame.InfoPlayer.verticesRecogidos = pickedVertices;

          if(pickedVertices == 0)
          {
              PlayerPrefs.SetInt("pickedVertices", 0);
          }


          if(pickedVertices == 1)
          {
              PlayerPrefs.SetInt("pickedVertices", 1);
          }
          if(pickedVertices == 2)
          {
              PlayerPrefs.SetInt("pickedVertices", 2);
          }
          if(pickedVertices == 3)
          {
              PlayerPrefs.SetInt("pickedVertices", 3);
          }
          if(pickedVertices == 4)
          {
              PlayerPrefs.SetInt("pickedVertices", 4);
          }
          if(pickedVertices == 5)
          {
              PlayerPrefs.SetInt("pickedVertices", 5);
          }
          if(pickedVertices == 6)
          {
              PlayerPrefs.SetInt("pickedVertices", 6);
          }
          if(pickedVertices == 7)
          {
              PlayerPrefs.SetInt("pickedVertices", 7);
          }
          if(pickedVertices == 8)
          {
              PlayerPrefs.SetInt("pickedVertices", 8);
          }

      
          if(allVertices[0].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice1", 1);
          } else {PlayerPrefs.SetInt("Vertice1", 0);}

          if(allVertices[1].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice2", 1);
          } else {PlayerPrefs.SetInt("Vertice2", 0);}

          if(allVertices[2].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice3", 1);
          } else {PlayerPrefs.SetInt("Vertice3", 0);}

          if(allVertices[3].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice4", 1);
          } else {PlayerPrefs.SetInt("Vertice4", 0);}

          if(allVertices[4].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice5", 1);
          } else {PlayerPrefs.SetInt("Vertice5", 0);}

          if(allVertices[5].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice6", 1);
          } else {PlayerPrefs.SetInt("Vertice6", 0);}

          if(allVertices[6].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice7", 1);
          } else {PlayerPrefs.SetInt("Vertice7", 0);}

          if(allVertices[7].activeSelf)
          {
              PlayerPrefs.SetInt("Vertice8", 1);
          } else {PlayerPrefs.SetInt("Vertice8", 0);}



     }


     public void LoadVertices()
     {

         if (PlayerPrefs.GetInt("Vertice1") == 1)
         {
             allVertices[0].SetActive(true);
            
         } 
         else{ allVertices[0].SetActive(false);}

         if (PlayerPrefs.GetInt("Vertice2") == 1)
         {
             allVertices[1].SetActive(true);
         } 
         else if ((PlayerPrefs.GetInt("Vertice2") != 1)){ allVertices[1].SetActive(false);}


         if (PlayerPrefs.GetInt("Vertice3") == 1)
         {
             allVertices[2].SetActive(true);
         } 
         else if ((PlayerPrefs.GetInt("Vertice3") != 1)){ allVertices[2].SetActive(false);}


         if (PlayerPrefs.GetInt("Vertice4") == 1)
         {
             allVertices[3].SetActive(true);
         } 
         else if ((PlayerPrefs.GetInt("Vertice4") != 1)){ allVertices[3].SetActive(false);}


         if (PlayerPrefs.GetInt("Vertice5") == 1)
         {
             allVertices[4].SetActive(true);
         } 
         else if ((PlayerPrefs.GetInt("Vertice5") != 1)){ allVertices[4].SetActive(false);}


         if (PlayerPrefs.GetInt("Vertice6") == 1)
         {
             allVertices[5].SetActive(true);
         } 
         else if ((PlayerPrefs.GetInt("Vertice6") != 1)){ allVertices[5].SetActive(false);}


         if (PlayerPrefs.GetInt("Vertice7") == 1)
         {
             allVertices[6].SetActive(true);
         } 
         else if ((PlayerPrefs.GetInt("Vertice7") != 1)){ allVertices[6].SetActive(false);}


         if (PlayerPrefs.GetInt("Vertice8") == 1)
         {
             allVertices[7].SetActive(true);
         } 
         else if ((PlayerPrefs.GetInt("Vertice8") != 1)){ allVertices[7].SetActive(false);}


          

          if (pickedVertices == 8)
          {
              readyForCutScene = false;
          }
     }
}