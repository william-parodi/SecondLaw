using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool isPaused = false; 

    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject difficultyUI;
    
    // Update is called once per frame
    void Start()
    {
        pauseMenuUI.SetActive(false);
        difficultyUI.SetActive(false);
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu(){

    }

    public void difficultyMenu() {
        pauseMenuUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
}
