using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public int health = 100;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void fixedUpdate()
    {
        if (Vector2.Distance(transform.position, player.position) >= 15)
        {
            Die();
        }
    }

}
