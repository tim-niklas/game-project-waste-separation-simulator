using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @class IslandMovement
* @brief This class is responsible for the movement of the islands
*/
public class IslandMovement : MonoBehaviour
{
    public float movementSpeed = 1;
 
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0,-1 * movementSpeed * Time.deltaTime);
    }
}
