using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    // float playerSize = 1f;

    public int controlSchemes;
    public JumpHelper canJump;

    private float speed = 4f;
    //public PlayerMovement player; // awkward naming, probably should've named the class "Player"
    private Rigidbody2D playerBody;
    private float defaultJumpPower = 6f;
    private float strongJumpPower = 9f;
    private float weakJumpPower = 4f;
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        controlSchemes = 1;
    }

    // Update is called once per frame
    void Update()
    {
        bool clearance = canJump.getJump(); // canJump is a helper, and getJump returns bool 
                                            // checking if player is on the ground
        timer += Time.deltaTime;
        if (timer > 5f)
        {
            Debug.Log(Input.GetAxis("Horizontal"));
            controlSchemes += 1;
            if (controlSchemes > 4)
            {
                controlSchemes = 1;
            }
            timer = 0;
        }

        switch (controlSchemes)
        {
            case 1: // default controls
                transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f); // movement
                if (Input.GetButtonDown("Jump") & clearance)
                {
                    PlayerJump(defaultJumpPower);
                }
                break;
            case 2:
                transform.position -= new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f); // movement
                if (Input.GetButtonDown("Jump") & clearance)
                {
                    PlayerJump(defaultJumpPower);
                }
                break;
            case 3:
                if(Input.GetButtonDown("Jump"))
                {
                    transform.position += new Vector3(speed * Time.deltaTime, 0f); // movement

                }
                if ((Input.GetAxis("Horizontal") > 0) & canJump.getJump())
                {
                    PlayerJump(strongJumpPower);
                }
                if ((Input.GetAxis("Horizontal") < 0))
                {
                    transform.position -= new Vector3(speed * Time.deltaTime, 0f); // movement

                }
                break;
            case 4:
                if (Input.GetButtonDown("Jump"))
                {
                    transform.position -= new Vector3(speed * Time.deltaTime, 0f); // movement

                }
                if ((Input.GetAxis("Horizontal") < 0) & canJump.getJump())
                {
                    PlayerJump(weakJumpPower);
                }
                if ((Input.GetAxis("Horizontal") > 0))
                {
                    transform.position -= new Vector3(speed * Time.deltaTime, 0f); // movement

                }
                break;
        }
                
    }

    public void PlayerJump(float power)
    {
        playerBody.velocity = new Vector3(playerBody.velocity.x, power * 1f);

    }
}
