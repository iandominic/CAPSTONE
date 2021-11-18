using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDialogNPC : MonoBehaviour
{
    public Image talk;
    public Image talk2;
    public Image talk3;
    public Image talk4;
    public Image talk5;
    public Image talk6;
    public int contact;
    public GameObject tambayNpc;
    DialogueIngame sn;

    void Start()
    {
        sn = gameObject.GetComponent<DialogueIngame>();
    }
   
    void Update()
    {
        if(contact == 1)
        {
            talk.gameObject.SetActive(true);
        }
        else if(contact == 2)
        {
            talk2.gameObject.SetActive(true);
        }
        else if (contact == 3)
        {
            talk3.gameObject.SetActive(true);
        }
        else if (contact == 4)
        {
            talk4.gameObject.SetActive(true);
        }
        else if (contact == 5)
        {
            talk5.gameObject.SetActive(true);
        }
        else if (contact == 6)
        {
            talk6.gameObject.SetActive(true);
        }
        else if(contact == 0)
        {
            talk.gameObject.SetActive(false);
            talk2.gameObject.SetActive(false);
            talk3.gameObject.SetActive(false);
            talk4.gameObject.SetActive(false);
            talk5.gameObject.SetActive(false);
            talk6.gameObject.SetActive(false);
        }
    }

    public void Dialog()
    { 
        talk.gameObject.SetActive(true);
    }

    public void Dialog2()
    { 
        talk.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "machoman")
        {
            contact = 1;
            Debug.Log("Can talk");
        }
        else if (collision.tag == "pulis_one")
        {
            contact = 2;
            Debug.Log("Can talk");
        }
        else if (collision.tag == "pulis_two")
        {
            contact = 3;
            Debug.Log("Can talk");
        }
        else if (collision.tag == "police_main")
        {
            contact = 4;
            Debug.Log("Can talk");
        }
        else if (collision.tag == "tambay_male" || collision.tag == "tambay_female")
        {
            contact = 5;
            Debug.Log("Can talk");
        }
        else if (collision.tag == "tambay")
        {
            contact = 6;
            Debug.Log("Can talk");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        contact = 0;
        Debug.Log("Cant talk");
    }
}
