using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundsEffectScript : MonoBehaviour
{
    public AudioSource buttonClick;
    public AudioClip sounds;
    public void buttonClickSoundEffect()
    {
        buttonClick.PlayOneShot(sounds);
    }
}
