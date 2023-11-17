using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyUnitScript : MonoBehaviour
{
    public float unitHP;

    public SpriteRenderer spriteFriend;

    private float damageTimer;

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
            damageTimer = .2f;
        }
        if (target.tag == "Pneu")
        {
            unitHP -= DifControlScript.pneuDamVal;
            damageTimer = .4f;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    public void GetDamage()
    {
        if (damageTimer > 0)
        {
            spriteFriend.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            spriteFriend.color = new Color32(255, 255, 255, 255);
        }
        damageTimer -= Time.deltaTime;
    }
}
