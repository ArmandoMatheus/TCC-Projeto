using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemyHP = 7;
    public float enemySpeed = 1f;
    public bool canBeHit;
    int lootNum;

    public bool hitPlayer = false;

    public GameObject[] trashLoot;
    public GameObject attack;
    public Transform attackSpawnPos;
    public float attackTimer, currentAttackTimer;

    public EnemyDetection enemyDetection;    
    
    void Update()
    {
        if (!hitPlayer)
        {
            Move();
        }
        currentAttackTimer -= Time.deltaTime;
        if (enemyHP <= 0)
        {
            Die();
        }
        Attack();
    }
    void Move()
    {
        Vector3 temp = transform.position;
        temp.x -= enemySpeed * Time.deltaTime;
        transform.position = temp;   
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet")
        {
            enemyHP--;
        }
        if (target.tag == "Ally")
        {
            hitPlayer = true;
        }
        if(target.tag == "Base")
        {
            Die();
        }
    }
    private void OnTriggerStay2D(Collider2D target)
    {
        if(target.tag == "Tijolo")
        {
            enemyHP -= Time.deltaTime * 0.5f;
        }
    }
    void OnTriggerExit2D(Collider2D target)
    {        
        if (target.tag == "Ally")
        {
            hitPlayer = false;
        }
    }
    void Die()
    {
        lootNum = Random.Range(2, 3);
        for (int i = 0; i < lootNum; i++)
        {
            Instantiate(trashLoot[Random.Range(0, 4)], transform.position, transform.rotation);
        }        
        Destroy(gameObject);
    }
    void Attack()
    {
        if (enemyDetection.seeAlly && currentAttackTimer <= 0)
        {
            Instantiate(attack, attackSpawnPos.position, attackSpawnPos.rotation);
            currentAttackTimer = attackTimer;
        }
    }
}
