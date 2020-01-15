using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Keys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKey("up"))
        {
            SceneManager.LoadScene("MenuScene");
        }

        if (Input.GetKey("down"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
