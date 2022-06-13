using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float coFriction;
    public Rigidbody2D player; 
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        player.AddForce(new Vector2(2,3), ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
