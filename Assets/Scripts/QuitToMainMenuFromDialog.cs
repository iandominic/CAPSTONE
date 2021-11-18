using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitToMainMenuFromDialog : MonoBehaviour
{
    public Image returnImageOption;
    public Button btn1;
    public Button btn2;

    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {
            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // Quit the application
                returnImageOption.gameObject.SetActive(true);
            }
        }
    }
    public void yesButton()
    {
        SceneManager.LoadScene(0);
    }

    public void noButton()
    {
        returnImageOption.gameObject.SetActive(false);
    }
}
