using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 120; // 2 minutes

    public bool timerStart = false; // bool for the countdown 3,2,1,GO

    public Text timerText;

    public AudioSource timerAudio;

    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        timerAudio.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timerStart == true) {

            string minutes = Mathf.Floor(currentTime / 60).ToString();
            string seconds = Mathf.Floor(currentTime % 60).ToString("00");

            timerText.text = minutes + ":" + seconds;

            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 10)
            {
                timerText.color = Color.red;
            }
            else if (currentTime <= 30)
            {
                timerText.color = Color.yellow;
            }

   
            if (currentTime <= 20)
            {
                timerAudio.UnPause();
            }
            else
            {
                timerAudio.Pause();
            }

            if (currentTime <= 1)
            {
                currentTime = 0;
                timerAudio.Pause();
                //Stop game (like Pausemenü) and show ScoreDisplay
                endScreen.SetActive(true);
            }

        }
    }
}
