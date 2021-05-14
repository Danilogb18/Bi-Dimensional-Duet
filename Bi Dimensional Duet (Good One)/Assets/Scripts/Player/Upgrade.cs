using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Upgrade : MonoBehaviour
{
    public GameObject upgradeOne;
    public GameObject upgradeTwo;
    public GameObject particles;
    public AudioSource sound;
    public static bool upgraded;
    public GameObject panel;
    public GameObject button;
    Collider2D collider;

    void Awake()
    {
        if (PlayerPrefs.GetInt("Upgraded") == 1)
        {
            PlayerPrefs.SetInt("Upgraded", 1);
        }

        else
        {
             PlayerPrefs.SetInt("Upgraded", 0);
        }

    }

    private void Start()
    {
        collider = GetComponent<Collider2D>();
        if (PlayerPrefs.GetInt("Upgraded") == 1)
        {
            upgradeOne.SetActive(true);
            upgradeTwo.SetActive(true);
            Destroy(gameObject);
        }

        else
        {
            upgradeOne.SetActive(false);
            upgradeTwo.SetActive(false);
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            upgradeOne.SetActive(true);
            upgradeTwo.SetActive(true);
            particles.SetActive(true);
            upgraded = true;
            sound.Play();
            collider.enabled = false;
            transform.localScale = new Vector3(0,0,0); // para que no se vea. si lo destruyo aqui no corre la corrutina
            NewControls.canPlay = false;
            PanelManager.canPause = false;
            StartCoroutine("ShowPanel");
        }
    }


    IEnumerator ShowPanel()
    {
        yield return new WaitForSeconds(3);
        panel.SetActive(true);
        yield return new WaitForSeconds (3);
        button.SetActive(true);
        Destroy(gameObject);
    }
}
