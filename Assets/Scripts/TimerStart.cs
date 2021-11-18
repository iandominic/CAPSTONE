using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStart : MonoBehaviour
{

    [SerializeField] TimerScript timer1;

    // Start is called before the first frame update
    void Start()
    {
        timer1.SetDuration(20).Begin();
    }

    
}
