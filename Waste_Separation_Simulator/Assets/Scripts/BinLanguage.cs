using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/**
* @class BinLanguage
* @brief This class is responsible to change the bin texts to german or english
*/
public class BinLanguage : MonoBehaviour
{
    public GameObject binGerman;
    public GameObject binEnglish;
    public GameObject diffController;
    bool language;

    // Start is called before the first frame update
    /**
    * @brief It checks in the DiffController object, if the bool language is true or not, and depending on that switches the active gameobjects.
    */
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
