using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRobotScript : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 movementDirection = Vector2.left;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Move the Goomba in the current direction
        rb.velocity = new Vector2(movementDirection.x * moveSpeed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // If collision, reverse movement and sprite direction
        if (collision.gameObject.CompareTag("ground"))
        {
            movementDirection = -movementDirection;
            FlipSprite();
        }
    }

    void FlipSprite()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
