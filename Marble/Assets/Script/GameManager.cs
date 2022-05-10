using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum State { basladi, durdu }
public class GameManager : MonoBehaviour
{
    private State currentState;
    private PlayerController playerController;
    private int puan;
    Animator kapi;

    [SerializeField]
    private GameObject kazandinText;
    // Start is called before the first frame update
    void Start()
    {
        currentState = State.basladi;
        kazandinText.SetActive(false);
        puan = 0;
        playerController = GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
        kapi = GameObject.Find("Kapi").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.PuanArtir)
        {
            puan++;
            playerController.PuanArtir = false;
            
        }

        if(puan == 4)
        {
            kapi.SetBool("KapiAcildi", true);
        }

        if(puan == 5)
        {
            currentState = State.durdu;
            kazandinText.SetActive(true);
            Time.timeScale = 0;
        }

        if(playerController.Dustum)
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
