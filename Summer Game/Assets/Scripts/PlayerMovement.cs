using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float sidewaysMoveSpeed;
    public Rigidbody playerRigidBody;

    
    // Use this for initialization
    void Start ()
    {
	    	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        playerRigidBody.AddForce(0, 0,moveSpeed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            playerRigidBody.AddForce(-sidewaysMoveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            playerRigidBody.AddForce(sidewaysMoveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            playerRigidBody.AddForce(0,0, .5f*moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            playerRigidBody.AddForce(0, 0, .5f * -moveSpeed * Time.deltaTime);
        }
        if (playerRigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Lost();
        }
    }
}
