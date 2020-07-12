using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    float playerSize = 1f;

    public float jumpPower = 4f;
    private float speed = 4f;

    private Rigidbody2D playerBody;


    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f); // movement


        // Raycast to check if player is close to ground to allow jump 

        RaycastHit2D jumpCheck = Physics2D.Raycast(new Vector3(transform.position.x, 
            transform.position.y - 0.5f), new Vector3(0, -1)); 

        if (jumpCheck.distance < playerSize * 0.05f && playerBody.velocity.y < 0.05f)
        {
            if (Input.GetButtonDown("Jump"))
            {
                playerBody.velocity = new Vector3(playerBody.velocity.x, jumpPower * 1f);
            }
        }    
    }
}
