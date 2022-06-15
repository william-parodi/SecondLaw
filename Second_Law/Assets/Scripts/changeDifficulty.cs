using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeDifficulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Easy(){

    }

    public void Medium(){

    }

    public void Hard(){

    }

    public void Back(){
        if (Pause_Menu.isPaused){
            SceneManager.LoadScene("SampleScene");
            Pause_Menu.Pause();
        }
    }
}
