using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/**
* @class ScoreController
* @brief This class is responsible for the score and the score display.
*/
public class ScoreController : MonoBehaviour
{

    public Text scoreText;
    public float scoreNumber = 0;
 
    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreNumber.ToString("0") + "P";
    }
}
