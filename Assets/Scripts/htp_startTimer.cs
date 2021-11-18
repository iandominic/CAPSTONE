using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class htp_startTimer : MonoBehaviour
{
    [SerializeField] htp_time timer2;
    // Start is called before the first frame update
    void Start()
    {
        timer2.SetDuration(120).Begin();
    }
}
