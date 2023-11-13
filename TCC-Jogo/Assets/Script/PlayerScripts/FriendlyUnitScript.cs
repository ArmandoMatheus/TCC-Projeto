using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyUnitScript : MonoBehaviour
{
    public float unitHP;
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
            unitHP -= DifControlScript.enemyDamVal;            
        }
        if (target.tag == "Pneu")
        {
            unitHP -= DifControlScript.pneuDamVal;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
