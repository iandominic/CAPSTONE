using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSettingsMenu : MonoBehaviour
{
   public void openSettingsMenu()
    {
        SceneManager.LoadScene(3);
    }
}
