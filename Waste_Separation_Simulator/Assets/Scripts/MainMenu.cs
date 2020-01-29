using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /**
    * @brief For MainMenu - Starts the GameScene
    */
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /**
    * @brief For MainMenu - Quit the game
    */
    public void QuitGame()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
    
        Application.Quit();
       
    }

 

}
