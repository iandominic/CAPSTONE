using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quittomain : MonoBehaviour
{
    public Image quitOption;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openmenu()
    {
        quitOption.gameObject.SetActive(true);
    }
}
