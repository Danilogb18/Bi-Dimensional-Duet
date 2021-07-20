using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textD;
    
    [TextArea(3,30)]
    public string [] paragraphs;

    private int index = 0;
    public float charVel;

    public bool pyramidDialogue;


    public GameObject okButton;
    public GameObject dialoguePanel;
    public GameObject talkButton;

    public int paragraphsRead = 0;


    public static bool lastParagraph;
    private bool finishedStory = false;
    public bool canTalk = false;
    private bool canSkip;
    private bool canCall;

    public int paragraphsToSkipBeggining;


    void Start()
    {
        okButton.SetActive(false);
        dialoguePanel.SetActive(false);
        index = 0;
        finishedStory = false;
        canSkip = false;
        canCall = true;
        canTalk = false;

    }


    void Update()
    {
        if (textD.text == paragraphs[index])
        {
            okButton.SetActive(true);
            StartCoroutine("MakeSkippable");

        }
        else
        {
            canSkip = false;
        }

        

    }

    public void Read()  
    {
        dialoguePanel.SetActive(true);
    }


    IEnumerator ShowText()
    {
        foreach(char letra in paragraphs[index].ToCharArray())
        {
            textD.text += letra;
            yield return new WaitForSeconds(charVel);
        }
        
    }

    public void NextParagraph()
    {
        if(canCall)
        {
            canCall = false;
        StartCoroutine("Adelantar");

        
        if (textD.text != paragraphs[index])
        {
            StopCoroutine("ShowText");
            textD.text = paragraphs[index];
            
        }


        okButton.SetActive(false);
        if(index < paragraphs.Length - 1 && canSkip)
        {
            canSkip = false;
            StartCoroutine("AddIndex");
            textD.text = "";
            StartCoroutine("ShowText");
            
        }

        else if (index == paragraphs.Length - 1 && canSkip)
        {
            canSkip = false;
            lastParagraph = true;
        }
        
        }
        
    }


    public void QuitDialogue()
    {
        if (lastParagraph)
        {
        dialoguePanel.SetActive(false);
        NewControls.canPlay = true;
        finishedStory = true;
        PanelManager.canPause = true;
        if (pyramidDialogue)
        {
            AdvancedAI.dialogueEnded = true;
            Debug.Log("conversacionjefe");
        }
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
             if (finishedStory)
             {
                 talkButton.SetActive(true);
                 canTalk = true;
                 canSkip = false;
                 
             }
             else{

            textD.text = "";
            lastParagraph = false;
            index = 0;
            dialoguePanel.SetActive(true);
            NewControls.canPlay = false;
            PanelManager.canPause = false;
            PanelManager.canPause = false;
            StartCoroutine("ShowText");
             }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        talkButton.SetActive(false);
        canTalk = false;
    }

    public void Talk()
    {
        if(canCall){

        canCall = false;
        StartCoroutine("Adelantar");
        if (canTalk || AdvancedAI.pyramidDefeated){
        Debug.Log("talking");
         textD.text = "";
         canTalk = false;
         index = 0 + paragraphsToSkipBeggining;
         PanelManager.canPause = false;
         lastParagraph = false;
         dialoguePanel.SetActive(true);
        NewControls.canPlay = false;
        StartCoroutine("ShowText");
        }

        }
        
    }


    IEnumerator MakeSkippable()
    {
        yield return new WaitForSeconds(0.5f);
        canSkip = true;
    }

    IEnumerator AddIndex()
    {
        index ++;
        yield return new WaitForSeconds(1f);
    }

    IEnumerator Adelantar()
    {
        
        yield return new WaitForSeconds(0.5f);
        canCall = true;
    }

}





