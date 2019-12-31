using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinController : MonoBehaviour
{
    public string sortOfWaste = ""; //Sort of waste -> BioWaste, GlassWaste, PaperWaste, RestWaste, YellowWaste, SonderWaste

    public int score = 0;

    // Lights


    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == sortOfWaste)
        {
            score += 10;
            //Green Light
        }
        else if (collision.gameObject.tag == "BioWaste")
        {
            score -= 10;
            //White Light -> BioWaste
            //Red Light SelfWaste
        }
        else if (collision.gameObject.tag == "GlassWaste")
        {
            score -= 10;
        }
        else if (collision.gameObject.tag == "RestWaste")
        {
            score -= 10;
        }
        else if (collision.gameObject.tag == "YellowWaste")
        {
            score -= 10;
        }
        else if (collision.gameObject.tag == "RestWaste")
        {
            score -= 10;
        }

        Destroy(collision.gameObject);
    }

}
