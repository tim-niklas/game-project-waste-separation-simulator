using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @brief This class is responsible for the barricade behind the boat that destroys the waste objects and keeps trakc of the minus points by detroy.
*/
public class ObjectDestroyer : MonoBehaviour
{
    public GameObject scoreTextObject; //get the scoreText
    public float minusPointsByDestroy = 15;

    // Destroy the object if it collide with the invisible wall
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        scoreTextObject.GetComponent<ScoreController>().scoreNumber -= minusPointsByDestroy;
    }

}
