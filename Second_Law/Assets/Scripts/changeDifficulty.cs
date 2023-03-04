//This script creates the functions to change the difficulty of the game when buttons are clicked on the difficulty menu UI -William

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeDifficulty : MonoBehaviour
{
    public GameObject difficultyUI;
    public GameObject pauseMenuUI;
    public Rigidbody2D player;

    void Start()
    {
        
    }

    //When activated sets the game to Easy difficulty
    public void Easy(){
        player.drag = 1f; //Sets the friction the player experiences
        print("easy"); //confirms the difficulty change to the console
        Back(); //Sends the player back to the pause/title menu
    }

    //When activated sets the game to Medium difficulty
    public void Medium(){
        player.drag = .5f;
        Back();
    }

    //When activated sets the game to Hard difficulty
    public void Hard(){
        player.drag = 0f;
        Back();
    }

    //Sends the player back to the pause/title menu
    public void Back(){
        //If the game is paused, send the user back to the main pause menu
        if(Pause_Menu.isPaused){
            difficultyUI.SetActive(false); //Disables the difficulty menu
            pauseMenuUI.SetActive(true); //reactivates the pause menu
        }
    }
}
