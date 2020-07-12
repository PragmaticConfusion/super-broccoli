using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHelper : MonoBehaviour
{
    private bool clearance = false;

    public bool getJump()
    {
        return clearance;
    }    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        clearance = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        clearance = false;
    }
}
