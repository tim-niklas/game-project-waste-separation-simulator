using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* @class WasteMovement
* @brief This class is responsible for the waste movement in water.
*/
public class WasteMovement : MonoBehaviour
{
    private bool inWater;
    public float movementSpeed = 0.75f; // Waste's speed

    /**
    * @brief Looks if the waste is in water, if so then move it
    */
    void Update()
    {
        if (inWater)
        {
            transform.rotation = Quaternion.Euler(Random.Range(2.5f, -2.5f), Random.Range(2.5f, -2.5f), Random.Range(2.5f, -2.5f)); //try to simulate how the object moves in water - TO-DO: improve
            transform.position = transform.position + new Vector3(0, 0, -1 * movementSpeed * Time.deltaTime);
        }
    }

    /**
    * @brief Waste in water
    */
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WaterLine")
        {
            inWater = true;
        }
    }

    /**
     * @brief Waste not in water
     */
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "WaterLine")
        {
            inWater = false;
        }

    }
}