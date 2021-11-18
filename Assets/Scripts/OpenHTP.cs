using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenHTP : MonoBehaviour
{
    private ProgressBar getCurrent;
    public GameObject Player;
    public GameObject howTo;
    public GameObject carrierMale;
    // Start is called before the first frame update
    void Start()
    {
        getCurrent = Player.GetComponent<ProgressBar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openHTP()
    {
        howTo.SetActive(true);
        Player.GetComponent<ProgressBar>().enabled = false;
        carrierMale.GetComponent<InfectionCarrier>().enabled = false;
        Time.timeScale = 0;
    }

    public void closeHTP()
    {
        howTo.SetActive(false);
        Player.GetComponent<ProgressBar>().enabled = true;
        carrierMale.GetComponent<InfectionCarrier>().enabled = true;
        Time.timeScale = 1;
    }

    public void closeHTPIcon()
    {
        howTo.SetActive(false);
        Player.GetComponent<ProgressBar>().enabled = true;
        carrierMale.GetComponent<InfectionCarrier>().enabled = true;
        Time.timeScale = 1;
    }
}
