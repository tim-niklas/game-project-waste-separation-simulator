/* SceneHandler.cs from https://medium.com/@setzeus/tutorial-steamvr-2-0-laser-pointer-bbc816ebeec5 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public GameObject settingsSubMenu;
    public GameObject startMenu;
    public Button play;
    public Button settings;
    public Button quit;
    public Button back;
    public Button english;
    public Button deutsch;
    public Button easy;
    public Button normal;
    public Button hard;
    

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Play")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(e.target.name == "Settings")
        {
            settingsSubMenu.SetActive(true);
            startMenu.SetActive(false);
        }
        else if (e.target.name == "back")
        {
            settingsSubMenu.SetActive(false);
            startMenu.SetActive(true);
        }
    }


    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was entered");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was exited");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was exited");
        }
    }
}