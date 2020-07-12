using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    float playerSize = 1f;

    private float speed = 4f;
    //public PlayerMovement player; // awkward naming, probably should've named the class "Player"
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

    }

    public void PlayerJump(float power)
    {
        playerBody.velocity = new Vector3(playerBody.velocity.x, power * 1f);

    }
}
