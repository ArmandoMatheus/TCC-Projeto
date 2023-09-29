using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public bool seeEnemy;
    public bool seeAlly;
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            seeEnemy = true;
        }
        if (target.tag == "Ally")
        {
            seeAlly = true;
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            seeEnemy = false;
        }
        if (target.tag == "Ally")
        {
            seeAlly = false;
        }
    }
}
