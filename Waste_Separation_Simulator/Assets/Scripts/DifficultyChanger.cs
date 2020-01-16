using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DifficultyChanger : MonoBehaviour
{
    public float minusTime = 5;


    public TMP_Text easyText;
    public TMP_Text mediumText;
    public TMP_Text hardText;

    public TMP_Text easyTextGerman;
    public TMP_Text mediumTextGerman;
    public TMP_Text hardTextGerman;

    public bool languageIsGerman = false;

    GameObject diffController;

    GameObject german;
    GameObject english;

    
    // Start is called before the first frame update
    void Start()
    {

        diffController = GameObject.FindWithTag("DiffController");

        easyText.GetComponent<TMP_Text>().color = Color.green;
        easyTextGerman.GetComponent<TMP_Text>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LanguageToGerman()
    {

        languageIsGerman = true;
        diffController.GetComponent<DifficultyController>().language = languageIsGerman;
        Debug.Log("Invoked German");
    }

    public void LanguageToEnglish()
    {

        languageIsGerman = false;
        diffController.GetComponent<DifficultyController>().language = languageIsGerman;
        Debug.Log("Invoked English");
    }


    public void Diffeasy()
    {
        minusTime = 5;
        diffController.GetComponent<DifficultyController>().minusTime = minusTime;
        easyText.GetComponent<TMP_Text>().color = Color.green;
        hardText.GetComponent<TMP_Text>().color = Color.black;
        mediumText.GetComponent<TMP_Text>().color = Color.black;
        // ---- GERMAN VERSION ------
        easyTextGerman.GetComponent<TMP_Text>().color = Color.green;
        hardTextGerman.GetComponent<TMP_Text>().color = Color.black;
        mediumTextGerman.GetComponent<TMP_Text>().color = Color.black;

        Debug.Log("Invoked Easy");
    }
    public void Diffmedium()
    {
        minusTime = 10;
        diffController.GetComponent<DifficultyController>().minusTime = minusTime;
        mediumText.GetComponent<TMP_Text>().color = Color.blue;
        easyText.GetComponent<TMP_Text>().color = Color.black;
        hardText.GetComponent<TMP_Text>().color = Color.black;
        // ------- GERMAN VERSION ------ -
        mediumTextGerman.GetComponent<TMP_Text>().color = Color.blue;
        easyTextGerman.GetComponent<TMP_Text>().color = Color.black;
        hardTextGerman.GetComponent<TMP_Text>().color = Color.black;
        Debug.Log("Invoked mediumText");
    }

    public void Diffhard()
    {
        minusTime = 15;
        diffController.GetComponent<DifficultyController>().minusTime = minusTime;
        hardText.GetComponent<TMP_Text>().color = Color.red;
        easyText.GetComponent<TMP_Text>().color = Color.black;
        mediumText.GetComponent<TMP_Text>().color = Color.black;
        // ------- GERMAN VERSION ------ 
        hardTextGerman.GetComponent<TMP_Text>().color = Color.red;
        easyTextGerman.GetComponent<TMP_Text>().color = Color.black;
        mediumTextGerman.GetComponent<TMP_Text>().color = Color.black;
        Debug.Log("Invoked hardText");
    }
}
