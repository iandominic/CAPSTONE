using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class SoundsSwitchButtonScript : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;

    //private int switchState = 1;
    //public GameObject switchButton;
    //private bool switchBtn = false;
    //private static SoundsSwitchButtonScript test;
    //Toggle toggle;
    //Vector2 handlePosition;
    //int index;

    public AudioSource audioMusic;
    public RawImage On;
    public RawImage Off;
    private bool muted = false;
    private void Awake()
    {
        /*toggle = GetComponent<Toggle>();

        handlePosition = uiHandleRectTransform.anchoredPosition;

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
        {
            OnSwitch(true);
        }
        */
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        } else
        {
            Load();
        }
        UpdateButtonIcon();
    }

    public void OnSwitch(bool on)
    {
        /*if (on)
        {
            uiHandleRectTransform.anchoredPosition = handlePosition * -1;
        } else
        {
            uiHandleRectTransform.anchoredPosition = handlePosition;
        }
        */

        //uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition;
    }

    //ETO UNG NAG PAPATAY NG TUGTOG MEN
    public void onSwitchButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioSource audioSource = GameObject.FindGameObjectWithTag("MusicMainBg").GetComponent<AudioSource>();
            audioSource.Pause();
        }
        else
        {
            muted = false;
            AudioSource audioSource = GameObject.FindGameObjectWithTag("MusicMainBg").GetComponent<AudioSource>();
            audioSource.Play();
        }

        Save();
        UpdateButtonIcon();
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    public void OnButton()
    {
        Off.gameObject.SetActive(false);
        On.gameObject.SetActive(true);
        onSwitchButtonPress();
    }

    public void OffButton()
    {
        Off.gameObject.SetActive(true);
        On.gameObject.SetActive(false);
        onSwitchButtonPress();
    }

    public void goBackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //UPDATE IMAGE 
    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            On.enabled = true;
            Off.enabled = false;
        } else
        {
            On.enabled = false;
            Off.enabled = true;
        }
    }
}
