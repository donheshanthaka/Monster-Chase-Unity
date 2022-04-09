using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{
    
    public void RestartGame()
    {
        // Loading the current scene again
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
        // Loading the main menu
        SceneManager.LoadScene("MainMenu");
    }

}
