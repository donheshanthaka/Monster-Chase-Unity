using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;
    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        // Getting the transform of the player using the tag
        player = GameObject.FindWithTag("Player").transform;
    }

    // LateUpdate is called once all calculations of the other Update methods are finished, Ex: after player movement calculation
    void LateUpdate()
    {
        // Getting the current position of the camera
        // The transform component below is not defined by us because, it is already defined as an attribute for the class that we are in right now
        // We had to define the transform component for the player, because we are calling that object through find tag method
        tempPos = transform.position;

        // Getting the player x position and passing that value to the temporary position vector 
        tempPos.x = player.position.x;

        // If the camera position is away from the left side bounds of the screen, it will be limited to the min x
        if (tempPos.x < minX)
        {
            tempPos.x = minX;
        }

        // The above logic is implemented but for the right bounds
        if (tempPos.x > maxX)
        {
            tempPos.x = maxX;
        }

        // Assigning the updated tempPos vector to the camera transform position
        transform.position = tempPos;
    }
}
