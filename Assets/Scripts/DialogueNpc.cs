using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class DialogueNpc : MonoBehaviour
{
    
    DialogueIngame sn;

    void Start()
    {
        sn = gameObject.GetComponent<DialogueIngame>();
    }

    void Update()
    {
      
    }

    public void Dialog()
    {
       
    }

    public void Dialog2()
    {
       
    }

    public void OnTriggerEnter(Collider collision)
    {
        
    }

    private void OnTriggerExit(Collider collision)
    {
        this.GetComponent<Animator>().Play("Walking");
        this.GetComponent<NavMeshAgent>().enabled = true;
        this.GetComponent<TambayAi>().enabled = true;
        
        Debug.Log("Cant talk");
    }
}
