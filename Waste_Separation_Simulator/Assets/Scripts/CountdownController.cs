using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 3f; // 3,2,1,GO

    public Text countdownText;
          
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
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
