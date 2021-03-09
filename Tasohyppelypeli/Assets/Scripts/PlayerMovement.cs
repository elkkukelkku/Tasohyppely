using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2;
    public Rigidbody2D rb2D;
    private float horizontalMovement;
    public int facing = 1;
    public bool canMove = true;
    void Start()
    {
        // Start is called before the first frame update
    }

    void Update()
    {
        // Update is called once per frame
        horizontalMovement=Input.GetAxis("Horizontal");
        float flipX = Input.GetAxisRaw("Horizontal");

        if(flipX != 0 && canMove == true){
            FlipPlayer(flipX);
        }
    }

    private void FixedUpdate(){
        walk();
    }

    public void walk(){
        Vector2 playerVelocity = new Vector2(horizontalMovement * moveSpeed, rb2D.velocity.y);
        rb2D.velocity = playerVelocity;
    }
    public void FlipPlayer(float x){
        transform.localScale = new Vector2(x,transform.localScale.y);
        facing = (int)x;
        
    }
}
