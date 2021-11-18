using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class close : MonoBehaviour
{
    public Image game;
    public GameObject game2;
    public GameObject game3;
    public Image game4;

    public Image active_state;
    public Image active_state2;
    public Image active_state3;

    public Image reply_one;
    public Image reply_two;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exitDialogue()
    {
        game.gameObject.SetActive(false);
        active_state.gameObject.SetActive(false);
        active_state2.gameObject.SetActive(false);
        active_state3.gameObject.SetActive(false);
    }

    public void exitDialogue2()
    {
        game2.gameObject.SetActive(false);
    }

    public void exitDialogue3()
    {
        game3.gameObject.SetActive(false);
    }

    public void exitDialogue4()
    {
        game4.gameObject.SetActive(false);
        active_state.gameObject.SetActive(false);
        active_state2.gameObject.SetActive(false);
        active_state3.gameObject.SetActive(false);
    }

    public void exitReply_one()
    {
        reply_one.gameObject.SetActive(false);
    }
    public void exitReply_two()
    {
        reply_two.gameObject.SetActive(false);
    }
}
