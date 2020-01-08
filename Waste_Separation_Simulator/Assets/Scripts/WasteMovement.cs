using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteMovement : MonoBehaviour
{

    private bool inWater;
    public float movementSpeed = 0.75f; // Waste's speed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Make the waste moving in the water
        if (inWater)
        {
            transform.rotation = Quaternion.Euler(Random.Range(2.5f, -2.5f), Random.Range(2.5f, -2.5f), Random.Range(2.5f, -2.5f)); //try to simulate how the object moves in water - TO-DO: improve
            transform.position = transform.position + new Vector3(0, 0, -1 * movementSpeed * Time.deltaTime);
        }
    }

    // Waste is in water
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WaterLine")
        {
            inWater = true;
        }
    }

    // Waste is not in water
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "WaterLine")
        {
            inWater = false;
        }

    }
}