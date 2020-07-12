using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public ScreenController eventSystem;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        eventSystem.ResetUI();
        eventSystem.WinGame();
    }
}
