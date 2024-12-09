using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMoveScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength;
    public float moveSpeed = 5f;
    public LogicScript logic;
    public bool robotIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Lose Game
        if (other.tag == "Enemy")
        {
            logic.gameOver();
            robotIsAlive = false;
        }
        // Win Game
        if (other.tag == "Win")
        {
            logic.winGame();
            robotIsAlive = false;
        }
    }

    void Update()
    {
        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) == true && robotIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;
        }
        //if (Input.GetKeyDown(KeyCode.D) == true)
        //{
        //    myRigidBody.velocity = Vector2.right * jumpStrength;
        //}
        //if (Input.GetKeyDown(KeyCode.A) == true)
        //{
        //    myRigidBody.velocity = Vector2.left * jumpStrength;
        //}

        //Left & Right Movement
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed;

        if (robotIsAlive == true)
        {
            transform.position += movement;
        }
    }
}
