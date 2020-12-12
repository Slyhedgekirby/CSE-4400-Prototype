using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour
{
    public int damage = 200;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        hitInfo.GetComponent<PlayerHealth>();
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        hitInfo.GetComponent<Enemy>();
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}
