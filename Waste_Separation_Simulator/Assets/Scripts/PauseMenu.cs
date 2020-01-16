using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject germanPause;
    public GameObject englishPause;
    public GameObject diffController;

    public bool german;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        diffController = GameObject.FindWithTag("DiffController");
        german = diffController.GetComponent<DifficultyController>().language;
        if (Input.GetButtonDown("Menu Button") == true)
        {
            if (german == true)
            {
                germanPause.SetActive(true);
            }
            if (german == false)
            {
                englishPause.SetActive(true);
            }
        }
       
        
    }
}
