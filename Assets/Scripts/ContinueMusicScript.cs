using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueMusicScript : MonoBehaviour
{
    private static ContinueMusicScript continue1;
    public AudioSource music;

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

    private void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("zxczxc"))
        {
            music.Stop();
        } 
    }
}
