using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;

/**
* @brief This class is responsible for UI in MenuScene and the interaction with the laser pointer.
*/

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

    public GameObject settingsSubMenuGerman;
    public GameObject startMenuGerman;
    public Button zurueck;
    public Button beenden;
    public Button englishInGerman;
    public Button deutschInGerman;
    public Button einfach;
    public Button normalGerman;
    public Button schwer;

    public Color hoverColor = Color.grey;
    public Color stopHoverColor = Color.white;
    public Color originalColor;
    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }
    // -------------------------- AUSFÜHRUNG VON ONCLICKS -------------------------------

    /**
    * @brief Here we execute the buttons methods when it is clicked
    *
    * When you hover with the pointer over a button and press the trigger key, the in unity written methods are executed here. 
    */
    public void PointerClick(object sender, PointerEventArgs e)
    {
        //--------------------------- MAIN MENU --------------------------------------
        if (e.target.name == "Play")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(e.target.name == "Settings" && GameObject.Find(e.target.name).activeSelf == true)
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
        }
        else if (e.target.name == "Quit" && GameObject.Find(e.target.name).activeSelf == true)
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
        }

        //--------------------------- SETTINGS MENU --------------------------------------
        else if (e.target.name == "back")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
            Debug.Log("back wurde gedrückt");
        }
        else if (e.target.name == "zurueck")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
            Debug.Log("zurueck wurde geklickt");
        }
        else if (e.target.name == "Deutsch")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
        }
        else if (e.target.name == "English")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
        }
        else if (e.target.name == "Easy")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
            Debug.Log("invoked easy");
        }
        else if (e.target.name == "Normal")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
        }
        else if (e.target.name == "Hard")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
        }
        //-----------------INFORMATIONSTERMINAL-------------------------
        else if (e.target.name == "Special" || e.target.name == "Bio" || e.target.name == "Glass" || e.target.name == "Paper" || e.target.name == "Residual" || e.target.name == "Packaging")
        {
            GameObject.Find(e.target.name).GetComponent<Button>().onClick.Invoke();
        }
    }
    //---------------------- FARBVERÄNDERUNG -----------------------------
    /**
    * @brief Here the hovercolour is changed on hovering over the button.
    *
    * We took a couple different colours for our buttons and changed to grey while hovering over them, to give the player feedback over what hes hovering.
    */
    public void PointerInside(object sender, PointerEventArgs e)
    {
        //--------------------------- MAIN MENU --------------------------------------
        if (e.target.name == "Play" && GameObject.Find(e.target.name).activeSelf == true)
        {
            //Debug.Log("Button was entered");
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Settings" && GameObject.Find(e.target.name).activeSelf == true)
        {
            
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Quit" && GameObject.Find(e.target.name).activeSelf == true)
        {
            
            e.target.GetComponent<Image>().color = hoverColor;
        }
        //--------------------------- SETTINGS MENU --------------------------------------
        else if (e.target.name == "back" && GameObject.Find(e.target.name).activeSelf == true)
        {
            
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "zurueck" && GameObject.Find(e.target.name).activeSelf == true)
        {
            
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Easy")
        {
           
            e.target.GetComponent<Image>().color = hoverColor;
        }
        else if (e.target.name == "Normal")
        {
            Debug.Log(e.target.name + " wird dunkler gemacht");
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
        //--------------------------- INFORMATIONSTERMINAL -------------------------------
        else if (e.target.name == "Special" || e.target.name == "Bio" || e.target.name == "Glass" || e.target.name == "Paper" || e.target.name == "Residual" || e.target.name == "Packaging")
        {
            originalColor = e.target.GetComponent<Image>().color; 
            e.target.GetComponent<Image>().color = hoverColor;
        }
    }
    /**
    * @brief Here the colour is changed back 
    *
    * When the player takes the pointer away from the button, it switches back to its original colour.
    */
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
        else if (e.target.name == "zurueck")
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
        else if (e.target.name == "English" )
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        else if (e.target.name == "Deutsch")
        {
            e.target.GetComponent<Image>().color = stopHoverColor;
        }
        //--------------------------- INFORMATIONSTERMINAL -------------------------------
        else if (e.target.name == "Special" || e.target.name == "Bio" || e.target.name == "Glass" || e.target.name == "Paper" || e.target.name == "Residual" || e.target.name == "Packaging")
        {
            e.target.GetComponent<Image>().color = originalColor;
        }
    }
}