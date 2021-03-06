using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton
    // This variable holds an instance for this class, this GameManager class can call its own methods inside the class
    public static GameManager instance;

    [SerializeField]
    private GameObject[] players;

    private int _CharIndex;
    public int CharIndex
    {
        get { return _CharIndex; }
        set { _CharIndex = value; }
    }

    private void Awake()
    {
        // Sets the instance variable to an instance of this class
        if (instance == null)
        {
            instance = this;
            // The below line makes sure that the game object will not get destroyed during loading
            // That means the GameManager object will stay when moving from the main menu to the game play
            DontDestroyOnLoad(gameObject);
        } else
        {
            // If the instance already exist, the duplicate will be destroyed
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Gameplay")
        {
            // The receieved character index is used to instantiate the player for the game
            Instantiate(players[CharIndex]);
        }
    }

} // class
