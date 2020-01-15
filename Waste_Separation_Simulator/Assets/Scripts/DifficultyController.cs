using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DifficultyController : MonoBehaviour
{
    public float minusTime = 5;
    public float plusTime = 2;

    public Button easy;
    public Button medium;
    public Button hard;
    public TMP_Text easyText;
    public TMP_Text mediumText;
    public TMP_Text hardText;
    public TMP_Text easyTextGerman;
    public TMP_Text mediumTextGerman;
    public TMP_Text hardTextGerman;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        easyText.GetComponent<TMP_Text>().color = Color.green;
        easyTextGerman.GetComponent<TMP_Text>().color = Color.green;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Diffeasy()
    {
        minusTime = 5;
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
