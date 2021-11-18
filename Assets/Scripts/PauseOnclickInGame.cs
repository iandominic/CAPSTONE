using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseOnclickInGame : MonoBehaviour
{
    public Image pauseMenu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void openPauseMenu()
    {
        pauseMenu.gameObject.SetActive(true);
        pauseMenu.transform.LeanScale(Vector2.one, 0.2f);

    }

    public void Exit()
    {
        pauseMenu.transform.LeanScale(Vector2.one, 1f).setEaseInBack();
    }
}
