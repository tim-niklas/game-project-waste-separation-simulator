using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/**
* @class CountdownController
* @brief This class is responsible for the 3,2,1,GO countdown and also starts the timer
*/
public class CountdownController : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 4f; // 3,2,1,GO

    public Text countdownText;

    public AudioSource countdownAudio;

    // Start is called before the first frame update
    /**
    * Starts the Countdown Audio and sets the time to the given countdown.
    *
    */
    void Start()
    {
        currentTime = startingTime;
        countdownAudio.GetComponent<AudioSource>().Play(0);
    }

    // Update is called once per frame
    /**
    * @brief If the countdown reaches 0, it starts the game.
    *
    */
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        
        if(currentTime > 1)
        {
            countdownText.text = currentTime.ToString("0");
        }
 
        else if(currentTime <= 1)
        {
           countdownText.text = "GO!";
        }
        
        if(currentTime < 0)
        {
            TimerController timerStart = GetComponent<TimerController>();
            timerStart.timerStart = true; // start the timer
            countdownText.gameObject.SetActive(false); // hide the countdown
        }

    }
}
