using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    [Header("Timer UI references :")]
    [SerializeField] private Text uiText;

    public GameObject gameover;
    public GameObject success;  
    public GameObject Player;
    [Space]
    private ProgressBar getCurrent;
    [Space]
    public Image three_star;
    public Image two_star;
    public Image one_star;

    public int Duration { get; private set; }

    private int remainingDuration;

    private void Start()
    {
        Time.timeScale = 1;
        getCurrent = Player.GetComponent<ProgressBar>();
    }

    private void Awake()
    {
        ResetTimer();
    }

    private void ResetTimer()
    {
        uiText.text = "00:00";

        Duration = remainingDuration = 0;
    }

    public TimerScript SetDuration(int seconds)
    {
        Duration = remainingDuration = seconds;

        return this;
    }

    public void Begin()
    {
        StopAllCoroutines();
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while(remainingDuration > 0)
        {
            UpdateUI(remainingDuration);
            remainingDuration--;

            yield return new WaitForSeconds(1f);

            if(remainingDuration == 0 && getCurrent.current <= 20)
            {
                getCurrent.current += 0;
                three_star.gameObject.SetActive(true);
                success.SetActive(true);
                Player.GetComponent<ProgressBar>().enabled = false;
            }
            else if (remainingDuration == 0 && getCurrent.current <= 60)
            {
                getCurrent.current += 0;
                two_star.gameObject.SetActive(true);
                success.SetActive(true);
                Player.GetComponent<ProgressBar>().enabled = false;
            }
            else if (remainingDuration == 0 && getCurrent.current > 60)
            {
                getCurrent.current += 0;
                one_star.gameObject.SetActive(true);
                success.SetActive(true);
                Player.GetComponent<ProgressBar>().enabled = false;
            }
            else if (remainingDuration > 0 && getCurrent.current >= getCurrent.maximum)
            {
                Pause();
                gameover.SetActive(true);
                Player.GetComponent<ProgressBar>().enabled = false;
            }
        }
        End();
    }

    private void UpdateUI(int seconds)
    {
        uiText.text = string.Format("{0:D2}:{1:D2}", seconds / 60, seconds % 60);
    }

    public void End()
    {
        ResetTimer();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
}
