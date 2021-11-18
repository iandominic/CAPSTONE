using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CovidDetector : MonoBehaviour
{
    public GameObject gameObject;
    public double maximum;
    public double current;
    public ProgressBar progress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Poison in");
        progress = GameObject.Find("ProgressBar").GetComponent<ProgressBar>();
        progress.GetCurrentFill();
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Poison out");
    }

}
