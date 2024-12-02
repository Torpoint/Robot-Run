using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMoveScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            myRigidBody.velocity = Vector2.right * jumpStrength;
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            myRigidBody.velocity = Vector2.left * jumpStrength;
        }
    }
}
