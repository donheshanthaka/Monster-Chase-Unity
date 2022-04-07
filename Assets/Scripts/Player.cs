using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    public float jumpForce = 11f;

    private float movementX;

    [SerializeField]
    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "Walk";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        anim.speed = 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
    }

    // Implementation of player movement
    void PlayerMoveKeyboard()
    {
        // Getting the keyboard input of left and right (A,D,<-, ->)
        movementX = Input.GetAxisRaw("Horizontal");

        // Updating the position using the transform component of the player
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer()
    {
        // going to the right side
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;

        } else if (movementX < 0)
        {
            // going to the left side
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;

        } else
        {
            // idle
            anim.SetBool(WALK_ANIMATION, false);
        }
        
    }
}
