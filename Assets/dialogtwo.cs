using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class dialogtwo : MonoBehaviour
{

    public Button btn;
    public Image civil_reply_one;
    public Image civil_reply_two;
    [Space]
    public Image dialogue;
    public GameObject dialogue2;
    public GameObject dialogue3;
    public Image dialogue4;
    public Image dialogue5;
    [Space]
    public Image dialogue_active;
    public Image dialogue2_active;
    public Image dialogue3_active;
    [Space]
    public Image minus_virus;
    public Image plus_virus;
    [Space]
    public Image minus_virus2;
    public Image plus_virus2;
    [Space]
    public Image minus_virus3;
    public Image plus_virus3;
    [Space]
    public GameObject Player;
    [Space]
    public GameObject gameover;
    [Space]
    public NavMeshAgent tambayNpc;



    private ProgressBar getCurrent;


    private int current;
    public GameObject tambay;

    Animator anim;
    NavMeshAgent tambayNpc2;

   

    public AudioSource audio;
    public AudioSource audio2;
    public AudioSource audio3;

    // Start is called before the first frame update
    void Start()
    {
        getCurrent = Player.GetComponent<ProgressBar>();
        anim = tambay.GetComponent<Animator>();
        tambayNpc2 = tambay.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenDialogue()
    {
        audio.Play();
        dialogue.gameObject.SetActive(true);
    }
    public void OpenDialogue2()
    {
        audio.Play();
        dialogue2.gameObject.SetActive(true);
    }
    public void OpenDialogue3()
    {
        audio.Play();
        dialogue3.gameObject.SetActive(true);
    }
    public void OpenDialogue4()
    {
        audio.Play();
        tambay.transform.LookAt(Player.transform);
        anim.GetComponent<Animator>().Play("Idle");
        tambayNpc2.GetComponent<NavMeshAgent>().enabled = false;
        tambay.GetComponent<TambayAi>().enabled = false;
        
    }

    public void OpenDialogue5()
    {
        audio2.Play();
        getCurrent.current += 20;

        dialogue2_active.gameObject.SetActive(true);
        dialogue_active.gameObject.SetActive(false);
        dialogue3_active.gameObject.SetActive(false);

        minus_virus.gameObject.SetActive(false);
        plus_virus.gameObject.SetActive(true);

        if (getCurrent.current >= 100)
        {
            gameover.gameObject.SetActive(true);
        }
    }

    public void OpenDialogue6()
    {
        audio3.Play();
        getCurrent.current -= 5;

        dialogue2_active.gameObject.SetActive(false);
        dialogue_active.gameObject.SetActive(false);
        dialogue3_active.gameObject.SetActive(true);

        minus_virus.gameObject.SetActive(true);
        plus_virus.gameObject.SetActive(false);

        civil_reply_one.gameObject.SetActive(true);
        dialogue.gameObject.SetActive(false);
        dialogue3_active.gameObject.SetActive(false);
    }

    public void OpenDialogue7()
    {
        audio.Play();
        dialogue5.gameObject.SetActive(true);
        dialogue_active.gameObject.SetActive(false);
      
    }

    public void OpenDialogue7_reply()
    {
        audio3.Play();
        getCurrent.current -= 5;

        minus_virus2.gameObject.SetActive(true);
        plus_virus2.gameObject.SetActive(false);
        minus_virus3.gameObject.SetActive(true);
        plus_virus3.gameObject.SetActive(false);

        civil_reply_two.gameObject.SetActive(true);
        dialogue5.gameObject.SetActive(false);
    }

    public void OpenDialogue8()
    {
        audio3.Play();
        getCurrent.current -= 5;

        minus_virus2.gameObject.SetActive(true);
        plus_virus2.gameObject.SetActive(false);
        minus_virus3.gameObject.SetActive(true);
        plus_virus3.gameObject.SetActive(false);

        dialogue2_active.gameObject.SetActive(false);
        dialogue_active.gameObject.SetActive(true);
        dialogue3_active.gameObject.SetActive(false);
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
    }
}
