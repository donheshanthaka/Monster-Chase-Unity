using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
        // Sets the instance variable to the current instance
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} // class
