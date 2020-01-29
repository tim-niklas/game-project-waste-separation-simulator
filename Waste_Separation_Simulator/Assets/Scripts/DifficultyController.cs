using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/**
* @brief This class is responsible to to get the difficulty and language in the GameScene from the MenuScene
*/
public class DifficultyController : MonoBehaviour
{

    public bool language;
    public float minusTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}