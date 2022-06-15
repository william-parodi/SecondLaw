using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D player;

    Touch touch;
    Vector2 touchPosition;
    Vector2 startPosition;
    double timer = 1.00;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = GameObject.FindGameObjectWithTag("startPosition").transform.position;
        player.freezeRotation = true;
        player.position = startPosition;
        print(player);
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer > 0){
            timer -= Time.deltaTime;
        }
        if (timer < 0){
            timer = 0;
        }
        if (!(Pause_Menu.isPaused)){
            //Applies a force relative to the distance the click is away 
            //from the center and the angle it is from the horizontal
            if (Input.GetMouseButtonDown(0) && timer == 0){
                touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                player.AddForce(touchPosition, ForceMode2D.Impulse);
                timer = 1.00;
            }

        }
       
    }
    private void OnTriggerEnter2D (Collider2D collision){
        if (collision.tag == "endZone"){
            print("you win!");
            resetPlayer();
        }
        else if (collision.tag == "death") {
            gameOver();
            resetPlayer();
        }
 
    }
    void gameOver(){
        print("game over");
    }
    void resetPlayer(){
        player.velocity = Vector2.zero;
        player.position = startPosition;
        timer = 1;
    }
}
