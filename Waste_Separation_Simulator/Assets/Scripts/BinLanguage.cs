using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/**
* @brief This class is responsible to change the bin texts to german or english
*/
public class BinLanguage : MonoBehaviour
{
    public GameObject binGerman;
    public GameObject binEnglish;
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
            binGerman.SetActive(true);
            binEnglish.SetActive(false);
        }
        else
        {
            binEnglish.SetActive(true);
            binGerman.SetActive(false);
        }
    }
}
