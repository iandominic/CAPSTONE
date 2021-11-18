using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayGameStart : MonoBehaviour
{
    private float timeLeft = 2f;
    public GameObject howToPlay;
    htp_ProgressBar pBar;



    public int gameover;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        
    }

    private void Awake()
    {
        Time.timeScale = 0;
    }

    IEnumerator delay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
    }
}
