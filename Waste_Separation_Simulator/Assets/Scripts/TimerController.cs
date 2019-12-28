using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 15f; // 2 minutes

    public bool timerStart = false; // bool for the countdown 3,2,1,GO

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerStart == true) {
      
            string minutes = ((int)currentTime / 60).ToString();
            string seconds = (currentTime % 60).ToString("00");

            currentTime -= 1 * Time.deltaTime;

            timerText.text = minutes + ":" + seconds;

            if (currentTime < 10)
            {
                timerText.color = Color.red;
            }
            else if (currentTime < 30)
            {
                timerText.color = Color.yellow;
            }
                
            if (currentTime < 0)
            {
                 currentTime = 0;
                 //Stop game (like Pausemenü) and show ScoreDisplay
             }
        }
    }
}
