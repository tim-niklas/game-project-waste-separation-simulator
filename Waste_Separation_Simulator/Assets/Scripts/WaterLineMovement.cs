using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLineMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0 * Time.deltaTime, 0, 1 * Time.deltaTime);
    }
}
