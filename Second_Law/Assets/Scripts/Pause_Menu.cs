//This script is what manages the entire pause menu and the actual pausing of the game - William

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool isPaused = false; //Indicates wether the game is paused or not

    public GameObject pauseMenuUI; //takes in the pause menu UI as a variable
    public GameObject pauseButton; //takes in the pause button object as a variable
    public GameObject difficultyUI; //takes in the difficulty menu UI as a variable
    
    // Update is called once per frame
    void Start()
    {
        //makes sure these UIs aren't on when the game starts
        pauseMenuUI.SetActive(false); 
        difficultyUI.SetActive(false);
    }

    //Resumes the game when activated
    public void Resume(){
        pauseMenuUI.SetActive(false); //turns off the pause menu
        pauseButton.SetActive(true); //turns the pause button back on
        difficultyUI.SetActive(false); //turns off difficulty menu
        Time.timeScale = 1f; //Resumes time at normal speed
        isPaused = false; //Indicates that the game isn't paused
    }

    //Pauses the game when activated
    public void Pause(){
        pauseMenuUI.SetActive(true); //Turns on the pause menu
        pauseButton.SetActive(false); //turns off the pause button
        Time.timeScale = 0f; //Shuts down the fabric of time
        isPaused = true; //Indicates that the game is paused
    }

    public void LoadMenu(){

    }

    //Turns on the difficulty menu when activated
    public void difficultyMenu() {
        pauseMenuUI.SetActive(false); //Turns off pause menu
        difficultyUI.SetActive(true); //turns on the difficulty menu
    }
}
