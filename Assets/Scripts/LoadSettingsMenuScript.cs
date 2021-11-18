using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSettingsMenuScript : MonoBehaviour
{
    private static LoadSettingsMenuScript continue1;

    public void Awake()
    {
        if (continue1 == null)
        {
            continue1 = this;
            DontDestroyOnLoad(continue1);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
