using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint;
    public float delayInSeconds;
    public GameObject enemyPrefab;
    public int spawnCount;

    public void Update()
    {
        if(Vector2.Distance(transform.position, player.position) <= 12f)
        {
            if (spawnCount > 0)
            {
                spawnCount = 0;
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
                StartCoroutine(SpawnEnemyWait());
            }
        }
    }

    IEnumerator SpawnEnemyWait()
    {
        yield return new WaitForSeconds(10f);
        spawnCount = 1;
    }

}
