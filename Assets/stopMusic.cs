using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopMusic : MonoBehaviour
{

    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
