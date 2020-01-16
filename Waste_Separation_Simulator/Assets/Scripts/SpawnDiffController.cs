using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiffController : MonoBehaviour
{

    public GameObject controller;
    public GameObject ControllerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        if (GameObject.FindGameObjectWithTag("DiffController") != null)
        {
           //Donothing

        }
        else
        {
            //instantiate the controller
            controller = Instantiate(ControllerPrefab);
           
        }
    }
}
