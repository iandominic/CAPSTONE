using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class htp_time : MonoBehaviour
{
    public Text uiText;
    // Start is called before the first frame update
    public int Duration { get; private set; }

    private int remainingDuration;

    private void Start()
    {

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

    public htp_time SetDuration(int seconds)
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
        while (remainingDuration > 0)
        {
            UpdateUI(remainingDuration);
            remainingDuration--;

            yield return new WaitForSeconds(1f);
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
