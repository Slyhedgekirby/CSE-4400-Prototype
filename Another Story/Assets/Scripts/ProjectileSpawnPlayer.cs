using UnityEngine;
using System.Collections;

public class ProjectileSpawnPlayer : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;
    public int Shot;
    public bool canShoot;
    public float delayInSeconds;


    private void Update()
    {
      if (Input.GetButtonDown("Fire1"))
            if(Shot > 0)
            {
                Shot = 0;
                Shoot();
                animator.SetBool("Attacking", true);
                StartCoroutine(ShootDelay());
            }
      
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(.3f);
        animator.SetBool("Attacking", false);
        Shot = 1;

    }
}
