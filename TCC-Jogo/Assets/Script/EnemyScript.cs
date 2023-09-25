using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemyHP = 7;
    public float enemySpeed = 2f;
    public bool canBeHit;

    public GameObject[] trashLoot;  
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 temp = transform.position;
        temp.x -= enemySpeed * Time.deltaTime;
        transform.position = temp;

        if(enemyHP <= 0)
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet")
        {
            enemyHP--;
        }
    }
    void Die()
    {        
        
            Instantiate(trashLoot[Random.Range(0, 3)], transform.position, transform.rotation);
        
        Destroy(gameObject);
    }
}
