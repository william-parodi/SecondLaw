using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float coFriction;

    public Rigidbody2D player; 

    Touch touch;
    Vector2 touchPosition;

    // Start is called before the first frame update
    void Start()
    {
        //player = GetComponent<Rigidbody2D>();
        print(player);
    }

    // Update is called once per frame
    private void Update()
    {
        //Applies a force relative to the distance the click is away 
        //from the center and the angle it is from the horizontal
        if (Input.GetMouseButtonDown(0)){
            touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            player.AddForce(touchPosition, ForceMode2D.Impulse);
        }

        //Checks if the character moves off screen and initiates game over if it is
        //Implementation is kinda crap
        //Vector2 playerPosition = Camera.main.WorldToScreenPoint(player.position);
       // if (Math.Abs(playerPosition.y) > Screen.height + 4 || Math.Abs(playerPosition.x) > Screen.width + 4){
        //    gameOver();
        //}
    }

    private void OnTriggerEnter2D (Collider2D collision){
        gameOver();
    }
    void gameOver(){
        print("game over");
    }
}