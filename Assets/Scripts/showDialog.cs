using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showDialog : MonoBehaviour
{

    public Transform box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on()
    {
        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(-400, 0.5f).setEaseOutExpo().delay = 0.1f;     
    }
}
