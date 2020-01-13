using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinController : MonoBehaviour
{
    public string sortOfWaste = ""; //Sort of waste -> BioWaste, GlassWaste, PaperWaste, RestWaste, YellowWaste, SonderWaste

    public float minusPoints = 5;
    public float plusPoints = 10;
    public float minusTime = 5;
    public float plusTime = 4;

    public GameObject scoreTextObject; //get the scoreText

    //[HideInInspector]
    public GameObject diffController;

    //Audio
    public AudioSource audioWrongWaste;
    public AudioSource audioRightWaste;

    // Materials for signal laps
    public Material MyLamp;
    public Material BioLamp;
    public Material GlassLamp;
    public Material PaperLamp;
    public Material RestLamp;
    public Material YellowLamp;
    public Material SonderLamp;

    //Lamp
    public GameObject signalLamp;

    // Start is called before the first frame update
    void Start()
    {
        //change the difficulty
        diffController = GameObject.Find("DifficultyController");
        minusTime = diffController.GetComponent<DifficultyController>().minusTime;
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
            signalLamp.GetComponent<MeshRenderer>().material = MyLamp;
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag == "BioWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime += minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = BioLamp;
        }
        else if (collision.gameObject.tag == "GlassWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = GlassLamp;
        }
        else if (collision.gameObject.tag == "RestWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = RestLamp;
        }
        else if (collision.gameObject.tag == "YellowWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = YellowLamp;
        }
        else if (collision.gameObject.tag == "SonderWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = SonderLamp;
        }
        else if (collision.gameObject.tag == "PaperWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = PaperLamp;
        }

        Destroy(collision.gameObject);
    }

}
