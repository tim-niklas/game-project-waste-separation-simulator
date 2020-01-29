using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* @brief This class is responsible to delete the values of the highscore (just for testing)
*/
public class deleteSaves : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
