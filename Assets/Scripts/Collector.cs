using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // Checking to see if the collector have collided with another object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Checking if the collided object has the tag Enemy
        if (collision.CompareTag("Enemy") || collision.CompareTag("Player"))
        {   
            // Destroy the game object that collided with the collector
            // That is why we have put collision.gameObject -> The collision has a reference to the object that collided
            Destroy(collision.gameObject);
        }
    }
}
