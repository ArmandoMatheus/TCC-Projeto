using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyUnitScript : MonoBehaviour
{
    public int unitHP;
    void Update()
    {
        if (unitHP <= 0)
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "EnemyAttack")
        {            
            unitHP--;            
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
