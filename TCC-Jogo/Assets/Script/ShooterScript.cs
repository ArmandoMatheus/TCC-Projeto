using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletSpawnPoint;
    public EnemyDetection enemyDetection;

    public float bulletTimer;
   
    /*
    public bool canShoot;
    public bool shoot;
    public float shooting;
    public float animTime = .2f;
    */
    void Update()
    {
        ShootTimer();
        Fire();       
    }
    void ShootTimer()
    {
        bulletTimer -= Time.deltaTime;
    }
    void Fire()
    {
        if (enemyDetection.seeEnemy == true && bulletTimer < 0)
        {
            Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bulletTimer = 1;
        }
    }
}
