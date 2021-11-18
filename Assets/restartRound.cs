using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restartRound : MonoBehaviour
{

    public GameObject howToPlay;
    public GameObject gamover;



    private HowToPlayGameStart gameover;

    int gameOver;
    bool check;

    [SerializeField] TimerScript timer;
    // Start is called before the first frame update
    void Start()
    {
        gameover = howToPlay.GetComponent<HowToPlayGameStart>();
        if(PlayerPrefs.GetInt("gameOver") == 1)
        {
            howToPlay.SetActive(false);
        } else
        {
            howToPlay.SetActive(true);
        }
    }

    private void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        PlayerPrefs.SetInt("gameOver", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(gameover.gameover.ToString());
    }
}
