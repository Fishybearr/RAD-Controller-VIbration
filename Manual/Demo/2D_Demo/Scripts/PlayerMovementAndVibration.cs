using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAndVibration : MonoBehaviour
{

    //---------------------------------------------Vibration code starts at line 115---------------------------------------------\\


    Rigidbody2D rb;
    float x;

    [Header("Character Controls")]

    [Space]

    [Tooltip("Speed of player")]
    public float speed;

    [Tooltip("Transform used to detect ground")]
    public Transform groundCheck;

    [Tooltip("Radius of ground check circle")]
    public float groundCheckRad;

    [Tooltip("What layer(s) is ground")]
    public LayerMask groundMask;

    [Tooltip("Determines if player is grounded")]
    public bool isGrounded = false;

    [Tooltip("Force of the player's jump")]
    public float jumpForce;

    //Bool to stop vibrate Coroutine from being called mulitple times when player is grounded
    bool canVibrate = true;

    // import vibration functions
    ControllerVibration vibrate = new ControllerVibration();

 
    
    void Start()
    {
        //Gets rigidbody on player
        rb = gameObject.GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        //Executes movement and groundcheck functions
        Move();
        Jump();
        GroundCheck();
    }






    /*
     * Moves the player horizontally
     */
    void Move()
    {
        // Horizontal input is stored in x
        x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;

        // Moves player horizontally
        rb.velocity = new Vector2(moveBy, rb.velocity.y);


       
    }


    /*
     * Allows the player to jump
     */
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {



            //Jump
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

           
           

        }
    }


    /*
     * Checks if player is grounded
     */
    void GroundCheck()
    {
        Collider2D collider = Physics2D.OverlapCircle(groundCheck.position, groundCheckRad, groundMask);

        if(collider != null)
        {
            
            isGrounded = true;
            

            // Actual Vibration Code \\
            if (canVibrate)
            {
                // The values for the motors are kind of strange
                // A low rumble is around 5,000 or so and a high rumble is closer to 30,000
                //Obviously you can play with these values however you want
                StartCoroutine(vibrate.VibrateForSeconds( .1f, 1, 5000, 5000));
            }


            // Controller cannot vibrate until player becomes grounded again
            canVibrate = false;
        }


        else
        {
            // Controller can now vibrate when isGrounded is true
            canVibrate = true;
            isGrounded = false;
        }
        
    }


}
