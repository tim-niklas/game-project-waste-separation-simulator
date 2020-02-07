using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;

/**
* @class PointerInGame
* @brief This class is responsible for the input of the laser pointer in the game scene.
*/
public class PointerInGame : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public GameObject player;
    
    public Button restart;
    public Button exit;
    public Color hoverColor = Color.grey;
    public Color buttonColor = Color.white;
    public Button neustart;
    public Button beenden;

    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("RightHand");
        laserPointer = player.GetComponent<SteamVR_LaserPointer>();

        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    /**
    * @brief Sends you to different scenes depending on what you click on

    */
    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Restart")
        {
            SceneManager.LoadScene("GameScene");
        }
        else if (e.target.name == "Exit")
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Restart")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Exit")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Restart")
        {
            e.target.GetComponent<Image>().color = buttonColor;
        }
        else if (e.target.name == "Exit")
        {
            e.target.GetComponent<Image>().color = buttonColor;
        }

    }
}