//This script controls the basic movements and functions of the character object - William Parodi

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D player; //Establishes the type of object the player is, and the way we will apply force to it

    Touch touch;  //Establishes the "Touch" object (idk what this does but it seems important)
    Vector2 touchPosition; //Establishes the Vector used to store the location of the most recent click
    Vector2 startPosition; //Establishes the vector used to store 

    double timer = 0;  //Counts the delay between each application of force
    double delay = 1.00; //Establishes the delay between each application of force

    private Pause_Menu pauseScript; //Establishes the variable that the "Pause_Menu" script will be saved in


    // Start is called before the first frame update
    void Start()
    {
        pauseScript = GetComponent<Pause_Menu>(); //imports the Pause_Menu script and all of its functions


        startPosition = GameObject.FindGameObjectWithTag("startPosition").transform.position; //Finds the area with the tag "start position"
        player.freezeRotation = true; //Makes the player not rotate
        player.position = startPosition; //Starts the player at the location that is designated as the "start position"

        //Prints the object and establishes in the console that the player has indeed spawned
        print(player);
    }

    // Update is called once per frame
    private void Update()
    {
        //Counts the delay between moves
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            timer = 0;
        }

        //When escape is click, activate the pause menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Pauses the game if it isn't paused
            if (!(Pause_Menu.isPaused))
            {
                //Activate the Pause function 
                pauseScript.Pause();
            }

            //Resumes the game if it is paused
            else if (Pause_Menu.isPaused)
            {
                //Activate the Pause function 
                pauseScript.Resume();
            }
        }

        if (!(Pause_Menu.isPaused))
        {
            /* Applies a force relative to the distance the click is away 
              from the center and the angle it is from the horizontal */
            if (Input.GetMouseButtonDown(0) && timer == 0)
            {   //Checks if the mouse button is clicked and that the delay has passed through
                touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Gets the position of the mouse which will be used to find the magnitude and direction of the force
                player.AddForce(touchPosition, ForceMode2D.Impulse); //Uses the mouse's position to apply an "Impulse" type force to the player
                timer = delay; //Activates the delay 
            }

        }

    }

    //Activates the "Win" function if the player collides with the end zone, or activate the "game over" if the player collides with an object with the tag "death"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "endZone")
        {
            win();
        }
        else if (collision.tag == "death")
        {
            gameOver();
        }

    }

    //Function that activates when the player dies
    void gameOver()
    {
        print("game over");
        resetPlayer();
    }

    //Function that activates when the player wins
    void win()
    {
        print("you win!");
        resetPlayer();
    }

    //Resets the player
    void resetPlayer()
    {
        player.velocity = Vector2.zero;
        player.position = startPosition;
        timer = 1;
    }
}
