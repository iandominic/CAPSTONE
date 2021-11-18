using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TambayAi : MonoBehaviour
{
    public GameObject theDestination;
    NavMeshAgent theAgent;
    private GameObject player;

    private void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        theAgent.SetDestination(theDestination.transform.position);
    }
}
