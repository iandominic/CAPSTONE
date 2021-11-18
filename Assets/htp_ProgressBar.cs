using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class htp_ProgressBar : MonoBehaviour
{

    public double maximum = 100;
    public double current;
    public Image mask;
    
    void Start()
    {
        current = 20;
    }

    // Update is called once per frame
    void Update()
    {
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;

        current += .08f;
    }
}
