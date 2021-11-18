using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextAndBackCoconut : MonoBehaviour
{
    [Header("How to one")]
    public Image one;
    public Image next;

    [Header("How to two")]
    public Image two;
    public Image back;

    [Header("Start button")]
    public Image start;

    [Header("GameObject")]
    public GameObject howToPlay;

    [Header("Carrier")]
    public GameObject carrier;
    InfectionCarrier getCurrent1;

    private void Start()
    {
        getCurrent1 = carrier.GetComponent<InfectionCarrier>();
    }
    public void nextPanel()
    {
        two.gameObject.SetActive(true);
        back.gameObject.SetActive(true);

        one.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        next.gameObject.SetActive(false);

    }

    public void backPanel()
    {
        one.gameObject.SetActive(true);

        back.gameObject.SetActive(false);
        two.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
    }

    public void StartGame()
    {
       
    }
}
