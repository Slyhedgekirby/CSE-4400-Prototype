using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    //The script that damadges the player
    public int damage = 40;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        hitInfo.GetComponent<PlayerHealth>();
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
