using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayPause : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject pauseButton;

    float videoDuration;

    [SerializeField] Slider progressBar;
    [SerializeField] Text timerText;


    void Start()
    {
        videoPlayer.Play();
        videoPlayer.Pause();


        videoDuration = (float)videoPlayer.clip.length;
    }

    void Update()
    {
        // Mettez � jour la jauge de progression et le timer en fonction du temps �coul�
        UpdateProgressBar();
        UpdateTimerText();
    }

    // Cette fonction est appel�e lorsque le bouton de pause est cliqu�
    public void OnPauseButtonClick()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playButton.SetActive(true);
            pauseButton.SetActive(false);
        }
        else
        {
            videoPlayer.Play();
            playButton.SetActive(false);
            pauseButton.SetActive(true);

        }
    }

    private void UpdateProgressBar()
    {
        if (videoDuration > 0f)
        {
            progressBar.value = (float)videoPlayer.time / videoDuration;

            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    private void UpdateTimerText()
    {
        float remainingTime = Mathf.Max(0f, videoDuration - (float)videoPlayer.time);
        timerText.text = FormatTime(remainingTime);
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        // R�initialisez la jauge et le timer � la fin de la vid�o (si vous le souhaitez)
        progressBar.value = 0f;
        timerText.text = FormatTime(videoDuration);
    }

    private string FormatTime(float seconds)
    {
        int minutes = Mathf.FloorToInt(seconds / 60f);
        int secondsInt = Mathf.FloorToInt(seconds % 60f);
        return string.Format("{0:00}:{1:00}", minutes, secondsInt);
    }
}

