using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Endscreen : MonoBehaviour
{
    public TMP_Text endText;
    public TMP_Text endTextEnglish;
    public GameObject scoreObject;

    public GameObject diffController;
    bool language;

    // Start is called before the first frame update
    void Start()
    {

        diffController = GameObject.FindWithTag("DiffController");
        language = diffController.GetComponent<DifficultyController>().language;
    }

    // Update is called once per frame
    void Update()
    {
        if (language == true)
        {
            endText.GetComponent<TMP_Text>().text = "ZEIT IST UM! PUNKTE: " + scoreObject.GetComponent<ScoreController>().scoreNumber;
          
        }
        else
        {
            endTextEnglish.GetComponent<TMP_Text>().text = "TIME'S UP! POINTS: " + scoreObject.GetComponent<ScoreController>().scoreNumber;   
        }
    }
  
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
