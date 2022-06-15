using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D player;

    Touch touch;
    Vector2 touchPosition;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 startPosition = GameObject.FindGameObjectWithTag("startPosition").transform.position;
        player.freezeRotation = true;
        player.position = startPosition;
        print(player);
    }

    // Update is called once per frame
    private void Update()
    {
        if (!(Pause_Menu.isPaused)){
            //Applies a force relative to the distance the click is away 
            //from the center and the angle it is from the horizontal
            if (Input.GetMouseButtonDown(0)){
                touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                player.AddForce(touchPosition, ForceMode2D.Impulse);
            }

        }
       
    }
    private void OnTriggerEnter2D (Collider2D collision){
        if (collision.tag == "endZone"){
            print("you win!");
        }
        else if (collision.tag == "outOfBounds") {
            gameOver();
        }
 
    }
    void gameOver(){
        print("game over");
    }
}
