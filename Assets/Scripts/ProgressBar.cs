using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{

    public double maximum = 100;
    public double current;
    public GameObject gameover;
    public Transform main;
    GameObject player;
    GameObject player2;
    public Image mask;

    public GameObject howToPlay;
    private HowToPlayGameStart gameOver;

    public bool poison;
    public float healthSpeedMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("pulis_one");
        player2 = GameObject.FindGameObjectWithTag("pulis_two");
        Debug.Log("THIS particular script is on " + gameObject.name);
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(poison == true)
        {
            GetCurrentFill();
        } else if(poison == false)
        {
            GetCurrentFill2();
        }
    }

    public void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;

        current += Time.deltaTime * healthSpeedMultiplier;

        if(current >= maximum)
        {
            gameover.gameObject.SetActive(true);

        }   
    }

    public void GetCurrentFill2()
    {
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
        current += 0;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "pulis_one")
        {
            transform.LookAt(main);
            poison = true;
            healthSpeedMultiplier = 5;
            Debug.Log("Poison In one");
        }
        else if (col.tag == "pulis_two")
        {
            poison = true;
            healthSpeedMultiplier = 10;
            Debug.Log("Poison In two");
        }
        else if (col.tag == "tambay")
        {
            poison = true;
            healthSpeedMultiplier = 2;
            Debug.Log("Poison In three");
        }
        else if (col.tag == "tambay_female" || col.tag == "tambay_male")
        {
            poison = true;
            healthSpeedMultiplier = 2f;
            Debug.Log("Poison In three");
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "pulis_one")
        {
            poison = false;
            Debug.Log("Poison Out one");
        } 
        else if(col.tag == "pulis_two")
        {
            poison = false;
            Debug.Log("Poison Out two");
        }
        else if (col.tag == "tambay" || col.tag == "tambay_female" || col.tag == "tambay_male")
        {
            poison = false;
            Debug.Log("Poison Out three");
        }
    }
}
