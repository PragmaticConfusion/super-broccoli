using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public ScreenController eventSystem;
    public GameObject player;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.gameObject.SetActive(false);
            eventSystem.ResetUI();
            eventSystem.StartGame();
            player.transform.position = new Vector3(-8f, -0.5f);
            player.gameObject.SetActive(true);
        }
       
    }
}
