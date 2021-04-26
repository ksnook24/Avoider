using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public player_controller movement;

    public Sprite gem;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Gem")
        {
            movement.enabled = false;
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        movement.enabled = false;
        FindObjectOfType<Game_Manager>().EndGame();
    }
}
