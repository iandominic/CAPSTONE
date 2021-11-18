using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLasonAddLason : MonoBehaviour
{
    public double maximum;
    public double current;
    GameObject player;
    GameObject player2;
    public Image mask;

    public bool poison;
    public float healthSpeedMultiplier = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("THIS particular script is on " + gameObject.name);
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (poison == true)
        {
            GetCurrentFill();
        }
        else if (poison == false)
        {
            GetCurrentFill2();
        }
    }

    public void GetCurrentFill()
    {

        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
        current += Time.deltaTime * healthSpeedMultiplier;
    }

    public void GetCurrentFill2()
    {
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
        current += 0;
    }
    void OnTriggerEnter(Collider col)
    {
        poison = true;
        Debug.Log("Poison In");
    }

    void OnTriggerExit(Collider col)
    {
        poison = false;
        Debug.Log("Poison Out");
    }
}
