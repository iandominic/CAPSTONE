using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class TambayAiTwo : MonoBehaviour
{
    public GameObject theDestination;
    NavMeshAgent theAgent;
    public GameObject player;

    public Image reply;


    Animator anim;

    public bool isWalking = true;

    private void Start()
    {
        anim = player.GetComponent<Animator>();
        theAgent = GetComponent<NavMeshAgent>();
    }

    public void UpdateMovement()
    {
        if(theAgent.GetComponent<NavMeshAgent>().enabled == false)
        {
            reply.gameObject.SetActive(false);
        } 
        else if(theAgent.GetComponent<NavMeshAgent>().enabled == true)
        {
            walking();
            theAgent.SetDestination(theDestination.transform.position);
        }
    }

    public void idle()
    {
        anim.GetComponent<Animator>().Play("Idle");
    }

    public void walking()
    {
        anim.GetComponent<Animator>().Play("Walking");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "desti_female")
        {
            isWalking = false;
        }
    }
}
