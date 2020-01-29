using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @class SpawnDiffController
* @brief This class is responsible that the DiffController (Saves the difficulty) is a singleton and that there is no another instance of it in every scene.
*/
public class SpawnDiffController : MonoBehaviour
{
    public GameObject controller;
    public GameObject ControllerPrefab;

    void Awake()
    {
        if (GameObject.FindGameObjectWithTag("DiffController") != null)
        {
           //Do nothing
        }
        else
        {
            //Instantiate the controller
            controller = Instantiate(ControllerPrefab);
        }
    }
}
