using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenQuitMenuScript : MonoBehaviour
{
    public void openQuitGameMenu()
    {
        SceneManager.LoadScene(2);
    }
}
