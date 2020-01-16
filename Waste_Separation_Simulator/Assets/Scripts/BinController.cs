using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinController : MonoBehaviour
{
    public string sortOfWaste = ""; //Sort of waste -> BioWaste, GlassWaste, PaperWaste, RestWaste, YellowWaste, SonderWaste

    float minusPoints = 75;
    float plusPoints = 100;
    float minusTime = 5;
    float plusTime = 3;

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
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "GlassWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = GlassLamp;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "RestWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = RestLamp;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "YellowWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = YellowLamp;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "SonderWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = SonderLamp;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "PaperWaste")
        {
            scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPoints;
            scoreTextObject.GetComponent<TimerController>().currentTime -= minusTime;
            audioWrongWaste.GetComponent<AudioSource>().Play(0);
            signalLamp.GetComponent<MeshRenderer>().material = PaperLamp;
            Destroy(collision.gameObject);
        }

        StartCoroutine(ExampleCoroutine());

       

    }

    IEnumerator ExampleCoroutine()
    {        
        //yield on a new YieldInstruction that waits for 0.5 seconds.
        yield return new WaitForSeconds(0.5f);
        signalLamp.GetComponent<MeshRenderer>().material = MyLamp;
    }

}
