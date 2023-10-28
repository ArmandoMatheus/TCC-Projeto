using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletSpawnPoint;

    public float bulletTimer;
    public float shootRange;

   
    /*
    public bool canShoot;
    public bool shoot;
    public float shooting;
    public float animTime = .2f;
    */
    void Update()
    {
        ShootTimer();

        if (CanSeeEnemy(shootRange))
        {
            Fire();
        }        
    }
    void ShootTimer()
    {
        bulletTimer -= Time.deltaTime;
    }
    void Fire()
    {
        if (bulletTimer < 0)
        {
            Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bulletTimer = 1;
        }
    }

    bool CanSeeEnemy(float range)
    {
        bool val = false;
        float castDist = range;
        Vector2 endPos = BulletSpawnPoint.position + Vector3.right * castDist;
        RaycastHit2D hit = Physics2D.Linecast(BulletSpawnPoint.position, endPos, 1<< LayerMask.NameToLayer("Ignore Raycast"));

        if(hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Enemy") || hit.collider.gameObject.CompareTag("Pneu"))
            {
                val = true;
            }
            else
            {
                val = false;
            }
            Debug.DrawLine(BulletSpawnPoint.position, hit.point, Color.red);
        }
        else
        {
            Debug.DrawLine(BulletSpawnPoint.position, endPos, Color.green);
        }
        return val;
    }
}
