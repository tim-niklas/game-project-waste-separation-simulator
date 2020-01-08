using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinController : MonoBehaviour
{
    public string sortOfWaste = ""; //Sort of waste -> BioWaste, GlassWaste, PaperWaste, RestWaste, YellowWaste, SonderWaste

    public float minusPoints = 10;
    public float plusPoints = 10;
    public float minusTime = 5;
    public float plusTime = 2;

    public GameObject scoreTextObject; //get the scoreText

    public AudioSource audioWrongWaste;
    public AudioSource audioRightWaste;
    // Materials for signal laps
    public Material BioLamp;
    public Material GlassLamp;
    public Material PaperLamp;
    public Material RestLamp;
    public Material YellowLamp;
    public Material SonderLamp;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == sortOfWaste)
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber += plusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += plusTime;
            audioRightWaste.GetComponent<AudioSource>().Play(0);

            //Green Light
            //sound good
        }
        else if (collision.gameObject.tag == "BioWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            //sound bad
            //White Light -> 
            //Red Light SelfWaste
        }
        else if (collision.gameObject.tag == "GlassWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += minusTime;
        }
        else if (collision.gameObject.tag == "RestWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += minusTime;
        }
        else if (collision.gameObject.tag == "YellowWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += minusTime;
        }
        else if (collision.gameObject.tag == "RestWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += minusTime;
        }
        else if (collision.gameObject.tag == "PaperWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += minusTime;
        }

        Destroy(collision.gameObject);
    }

}
