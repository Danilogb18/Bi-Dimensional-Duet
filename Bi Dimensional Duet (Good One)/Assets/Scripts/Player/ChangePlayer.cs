using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChangePlayer : MonoBehaviour
{
    
    private PlayerControls controls = null;

    public GameObject cubito;
    public GameObject triangulo;


    public static bool cubitoActive;
    private bool canChange = false;
    public AudioSource changeSound;
    public GameObject checkpointMessage;
    public GameObject vertices;
    public Transform miniBox;
    public Animator camaraAnim;
    Vertices scriptVertices;
    VerticesLevel2 scriptVertices2;
    PanelManager panelmanager;
    NewControls newControls; 

    public GameObject bossAdvicePanel;
    public GameObject particles;
    public GameObject firstTransformer;
    public GameObject secondTransformer;

    [SerializeField]
    bool isSecondTransformer;


    private bool notJustChanging = true;


    public static bool firstChange; //para mostrar el consejo del triangulo
    public GameObject changeAdvice; //el consejo del triangulo


    void Start()
    {
        if(PlayerPrefs.GetInt("Checkpoint") == 1) // 1 es verdadero y 0 es falso.
        {
              PlayerPrefs.SetInt("Checkpoint", 1);
        }

        else
        {
            PlayerPrefs.SetInt("CheckPoint", 0);
        }



        cubito.gameObject.SetActive(true);
        triangulo.gameObject.SetActive(false);
        cubitoActive = true;
        scriptVertices = vertices.GetComponent<Vertices>();
        scriptVertices2 = vertices.GetComponent<VerticesLevel2>();

        panelmanager = GameObject.FindGameObjectWithTag("PlayerInteractionZone").GetComponent<PanelManager>();
        newControls = GameObject.FindGameObjectWithTag("Player").GetComponent<NewControls>();
       

        CargarPartida();
            if (Vertices.pickedVertices == 4)
            {
                newControls.ShowKey();
                GetKey.gotKey = true;
            }

            
        
    }

    void Awake()
    {
       firstChange = true;
       controls = new PlayerControls();
    }


    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }

    void Update()
    {
        
    }


    void OnTriggerStay2D(Collider2D other)
    {

        var movementInput = controls.Player.Change.ReadValue<Vector2>();

        if (cubitoActive)
        {
            cubito.gameObject.SetActive(true);
            triangulo.gameObject.SetActive(false);
            camaraAnim.SetBool("cubitoActive", true);
        }


        if (cubitoActive == false)
        {
            cubito.gameObject.SetActive(false);
            triangulo.gameObject.SetActive(true);
            camaraAnim.SetBool("cubitoActive", false);
            

        }


        if (other.transform.tag == "Player" && movementInput.x > 0 && canChange) //change player
        {
            notJustChanging = false;
            cubitoActive =! cubitoActive;
            cubito.transform.position = new Vector3(transform.position.x, transform.position.y + 5, 1.3f);
            triangulo.transform.position = new Vector3(transform.position.x, transform.position.y + 5, 1.3f);
            canChange = false;
            changeSound.Play();
            DamageObject.life = 3;
            GuardarPartida();
            if (firstChange)
            {
                firstChange = false;
                StartCoroutine("ChangeAdvice");
            }
            StartCoroutine("CheckPointMessage");
        }

        if (movementInput.x == 0)
        {
            canChange = true;
        }
    }

    


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {   
        if(notJustChanging)
        {
        panelmanager.ChangeMessage();
        }
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
       
        panelmanager.ReturnChangeMessage();
        
    }


    IEnumerator CheckPointMessage()
    {
        checkpointMessage.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        checkpointMessage.SetActive(false);
        notJustChanging = true;
    }


    public void GuardarPartida()
    {
       PlayerPrefs.SetInt("Checkpoint", 1);
       particles.SetActive(true);

       if(isSecondTransformer)
       {
          PlayerPrefs.SetInt("Checkpoint", 2); 
          Debug.Log("issecondtransformer");
       }

       else {PlayerPrefs.SetInt("Checkpoint", 1);}

       if(PlayerPrefs.GetInt("ActualLevel") == 2)
       {
       scriptVertices2.SaveVertices();
       if (Upgrade.upgraded)
       {
           PlayerPrefs.SetInt("Upgraded", 1);
       }
       }

       if(PlayerPrefs.GetInt("ActualLevel") == 1)
       {
           scriptVertices.SaveVertices();
       }
       



    }


    public void CargarPartida()
    {

        if(PlayerPrefs.GetInt("ActualLevel") == 2)
       {
     //        scriptVertices2.SaveVertices();
            if(PlayerPrefs.GetInt("Checkpoint") == 1){
            cubito.transform.position = new Vector3(firstTransformer.transform.position.x, firstTransformer.transform.position.y + 15, 1.3f);
            //cubito.transform.position = new Vector3(lastTransformer.transform.position.x, lastTransformer.transform.position.y + 15, 1.3f);
            triangulo.transform.position = new Vector3(firstTransformer.transform.position.x, firstTransformer.transform.position.y + 15, 1.3f);
            //triangulo.transform.position = new Vector3(lastTransformer.transform.position.x, lastTransformer.transform.position.y + 15, 1.3f);
            Debug.Log("firstCheckpoint"); 
            miniBox.position = new Vector3(-895, -297, 1);
            particles.SetActive(true);
            CheckGround.platformController = true;
    
            }
    
            else if(PlayerPrefs.GetInt("Checkpoint") == 2){
            cubito.transform.position = new Vector3(secondTransformer.transform.position.x, secondTransformer.transform.position.y + 15, 1.3f);
            triangulo.transform.position = new Vector3(secondTransformer.transform.position.x, secondTransformer.transform.position.y + 15, 1.3f);
            Debug.Log("segundocheckpoint");
            miniBox.position = new Vector3(-895, -297, 1);
            particles.SetActive(true);
            CheckGround.platformController = true;
    
            }
       }

       if(PlayerPrefs.GetInt("ActualLevel") == 1)
       {
       //scriptVertices.SaveVertices();
        if(PlayerPrefs.GetInt("Checkpoint") == 1){
        cubito.transform.position = new Vector3(transform.position.x, transform.position.y + 15, 1.3f);
        triangulo.transform.position = new Vector3(transform.position.x, transform.position.y + 15, 1.3f);
        miniBox.position = new Vector3(104, -38.1f, 1);
        particles.SetActive(true);


        }
       }
        
        

        if (NewControls.enteredBossZone)
        {
            bossAdvicePanel.SetActive(true);
            NewControls.canPlay = false;
        }
    }

    public void HideChangeAdvice()
    {
        changeAdvice.SetActive(false);
    }

    IEnumerator ChangeAdvice()
    {
        yield return new WaitForSeconds(2);
        changeAdvice.SetActive(true);
    }




}






