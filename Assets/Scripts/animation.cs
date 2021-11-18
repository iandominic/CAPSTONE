using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animation : MonoBehaviour
{
    public bool pause = false;
    public GameObject pauseMenu;
    public GameObject HTP;

    private ProgressBar getCurrent;
    private InfectionCarrier getCurrent1;
    public GameObject Player;
    public GameObject carrierMale;
    private CapsuleCollider collide;

    // Start is called before the first frame update
    void Start()
    {
        getCurrent = Player.GetComponent<ProgressBar>();
        getCurrent1 = carrierMale.GetComponent<InfectionCarrier>();
        getCurrent = carrierMale.GetComponent<ProgressBar>();
        collide = carrierMale.GetComponent<CapsuleCollider>();
    }

    public void Open()
    {
        carrierMale.GetComponent<InfectionCarrier>().enabled = false;
        pauseMenu.gameObject.SetActive(true);
        Player.GetComponent<ProgressBar>().enabled = false;
        HTP.gameObject.SetActive(false);
        Time.timeScale = 0f;  
    }

    public void Close()
    {
        carrierMale.GetComponent<InfectionCarrier>().enabled = true;
        Debug.Log("random");
        Player.GetComponent<ProgressBar>().enabled = true;
        pauseMenu.gameObject.SetActive(false);
        HTP.gameObject.SetActive(true);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
