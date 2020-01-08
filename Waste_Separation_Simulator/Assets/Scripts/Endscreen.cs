using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Endscreen : MonoBehaviour
{
    public TMP_Text endText;
    public GameObject scoreObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        endText.GetComponent<TMP_Text>().text = "ZEIT IST UM! PUNKTE: " + scoreObject.GetComponent<ScoreController>().scoreNumber;
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
