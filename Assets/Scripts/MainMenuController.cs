using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        // Getting the name of the selected object, only two to be selected...either button 0 or 1 and the converting that name to int
        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        // Setting the selected character index as the character index of the GameManager instance's static variable
        GameManager.instance.CharIndex = selectedCharacter;

        // The scene manager will start playing the scene that correspond to the string passed in
        //SceneManager.LoadScene("Gameplay");
    }
} // class
