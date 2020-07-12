using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHelper : MonoBehaviour
{
    private bool clearance = false;
    private float defaultJumpPower = 4f; // normal jump power, can be changed for special jump cases
    public PlayerMovement playerCharacter;

    // Start is called before the first frame update
    void Start()
    {
        //player )
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") & clearance)
        {
            playerCharacter.PlayerJump(defaultJumpPower);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        clearance = true;

        Debug.Log("clearance is now true");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        clearance = false;
        Debug.Log("clearance is now false");
    }
}
