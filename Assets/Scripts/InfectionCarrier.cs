using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionCarrier : MonoBehaviour
{
    public GameObject Player;
    private ProgressBar getCurrent;
    public float lakas = 5f;

    public bool pos;

    // Start is called before the first frame update
    void Start()
    {
        getCurrent = Player.GetComponent<ProgressBar>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pos == true)
        {
            inside(lakas);
        } else if(pos == false)
        {
            outside();
        }
    }

    public void inside(float amount)
    {
        getCurrent.current += .05f;
    }

    public void outside()
    {
        getCurrent.current += 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "tambay_female")
        {
            pos = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "tambay_female")
        {
            pos = false;
        }
    }
}
