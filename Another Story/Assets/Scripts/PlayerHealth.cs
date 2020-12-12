using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Transform respawnLocation;
    public int health = 200;
    public GameObject player;

    public void TakeDamage(int damage)
    {
        health -= damage;


        if (health <= 0)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        player.transform.position = respawnLocation.transform.position;
        health = 200;
    }

}
