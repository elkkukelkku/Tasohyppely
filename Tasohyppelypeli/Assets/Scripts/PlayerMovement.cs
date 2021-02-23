using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2;
    public Rigidbody2D rb2D;
    private float horizontalMovement;

    void Start()
    {
        // Start is called before the first frame update
    }

    void Update()
    {
        // Update is called once per frame
        horizontalMovement=Input.GetAxis("Horizontal");
    }
    private void FixedUpdate(){
        Vector2 playerVelocity = new Vector2(horizontalMovement * moveSpeed, rb2D.velocity.y);
        rb2D.velocity = playerVelocity;
    }
}
