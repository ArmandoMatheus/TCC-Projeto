using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public bool seeEnemy;
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            seeEnemy = true;
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            seeEnemy = false;
        }
    }
}
