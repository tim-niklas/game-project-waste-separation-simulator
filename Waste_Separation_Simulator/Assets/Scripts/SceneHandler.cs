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
        if (e.target.name == "Play")
        {
            //Debug.Log("Button was entered");
            play.GetComponent<Image>().color = hoverColor;
                
        }
        else if (e.target.name == "Settings")
        {
            settings.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "back")
        {
            back.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Quit")
        {
            quit.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Easy")
        {
            easy.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Normal")
        {
            normal.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Hard")
        {
            hard.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "English")
        {
            english.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Deutsch")
        {
            deutsch.GetComponent<Image>().color = hoverColor;
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Play")
        {
            
            play.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "back")
        {
            back.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Settings")
        {
            settings.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Quit")
        {
            quit.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Easy")
        {
            easy.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Normal")
        {
            normal.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Hard")
        {
            hard.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "English")
        {
            english.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Deutsch")
        {
            deutsch.GetComponent<Image>().color = stopHoverColor;
        }
    }
}