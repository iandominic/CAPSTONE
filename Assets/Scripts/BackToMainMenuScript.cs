﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenuScript : MonoBehaviour
{
    public void goBackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
