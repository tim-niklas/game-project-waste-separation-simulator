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
    public GameObject settingsSubMenuGerman;
    public GameObject startMenuGerman;
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
    public Color hoverColor = Color.grey;
    public Color stopHoverColor = Color.white;
    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        //--------------------------- MAIN MENU --------------------------------------
        if (e.target.name == "Play")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(e.target.name == "Settings")
        {
            settingsSubMenu.SetActive(true);
            startMenu.SetActive(false);
        }
        //--------------------------- SETTINGS MENU --------------------------------------
        else if (e.target.name == "back")
        {
            settingsSubMenu.SetActive(false);
            startMenu.SetActive(true);
        }
        else if (e.target.name == "Easy")
        {
            easy.onClick.Invoke();
            Debug.Log("invoked easy");
        }
        else if (e.target.name == "Normal")
        {
            normal.onClick.Invoke();
        }
        else if (e.target.name == "Hard")
        {
            hard.onClick.Invoke();
        }
    }


    public void PointerInside(object sender, PointerEventArgs e)
    {
        //--------------------------- MAIN MENU --------------------------------------
        if (e.target.name == "Play")
        {
            //Debug.Log("Button was entered");
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Settings")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Quit")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        //--------------------------- SETTINGS MENU --------------------------------------
        else if (e.target.name == "back")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Easy")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Normal")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Hard")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "English")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Deutsch")
        {
            e.target.GetComponent<Image>().color = hoverColor;
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        //--------------------------- MAIN MENU --------------------------------------
        if (e.target.name == "Play")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        
        else if (e.target.name == "Settings")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Quit")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        //--------------------------- SETTINGS MENU --------------------------------------
        else if (e.target.name == "back")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Easy")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Normal")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Hard")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "English")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Deutsch")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
    }
}