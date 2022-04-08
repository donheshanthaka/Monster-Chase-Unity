using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        // The scene manager will start playing the scene that correspond to the string passed in
        SceneManager.LoadScene("Gameplay");
    }
} // class
