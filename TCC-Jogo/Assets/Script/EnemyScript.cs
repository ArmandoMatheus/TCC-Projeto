using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemyHP = 7;
    public float enemySpeed = 1f;
    public bool canBeHit;
    int lootNum;

    public GameObject[] trashLoot;
    public GameObject attack;
    public Transform attackSpawnPos;
    public float attackTimer, currentAttackTimer;

    public float attackRange;

    void Update()
    {
        currentAttackTimer -= Time.deltaTime;
        if (enemyHP <= 0)
        {
            Die();
        }

        if (CanSeePlayer(attackRange))
        {
            Attack();
        }
        else
        {
            Move();
        }
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
    }
    private void OnTriggerStay2D(Collider2D target)
    {
        if(target.tag == "Tijolo")
        {
            enemyHP -= Time.deltaTime * 0.5f;
        }
        if(target.tag == "Base")
        {
            Die();
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
        if (currentAttackTimer <= 0)
        {
            Instantiate(attack, attackSpawnPos.position, attackSpawnPos.rotation);
            currentAttackTimer = attackTimer;
        }
    }
    bool CanSeePlayer(float range)
    {
        bool val = false;
        float castDist = -range;
        Vector2 endPos = attackSpawnPos.position + Vector3.right * castDist;
        RaycastHit2D hit = Physics2D.Linecast(attackSpawnPos.position, endPos, 1 << LayerMask.NameToLayer("PlayerLayer"));

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Ally"))
            {
                val = true;
            }
            else
            {
                val = false;
            }
            Debug.DrawLine(attackSpawnPos.position, hit.point, Color.red);
        }
        else
        {
            Debug.DrawLine(attackSpawnPos.position, endPos, Color.green);
        }
        return val;
    }
}
