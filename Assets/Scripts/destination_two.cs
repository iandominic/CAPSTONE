using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class destination_two : MonoBehaviour
{
    public int pivotPoint = 0;
    public GameObject tambay;

    Animator anim;
    NavMeshAgent tambayNpc2;


    public void Start()
    {
        anim = tambay.GetComponent<Animator>();
        tambayNpc2 = tambay.GetComponent<NavMeshAgent>();
        anim.GetComponent<Animator>().Play("Idle_Female");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "tambay_female")
        {
            anim.GetComponent<Animator>().Play("Idle_Female");
            tambayNpc2.GetComponent<NavMeshAgent>().enabled = false;
            tambay.GetComponent<TambayAiTwo>().enabled = false;
        }
    }  
}
