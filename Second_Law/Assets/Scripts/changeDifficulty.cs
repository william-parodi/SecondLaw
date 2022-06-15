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

    public void Easy(){
        player.drag = 1f;
        print("easy");
        Back();
    }

    public void Medium(){
        player.drag = .5f;
        Back();
    }

    public void Hard(){
        player.drag = 0f;
        Back();
    }

    public void Back(){
        difficultyUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }
}
