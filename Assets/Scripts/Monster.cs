using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Getting a reference to the RigidBody
        myBody = GetComponent<Rigidbody2D>();

        speed = 2;
    }


    // FixedUpdate is called every fixed framerate
    void FixedUpdate()
    {
        // Speed for the x value, y is kept the same calling its own y
        // Updating the x value in velocity will increase the walk speed of left to right
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }
}
