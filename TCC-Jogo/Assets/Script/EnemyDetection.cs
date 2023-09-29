using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public bool seeEnemy;
    public bool seeAlly;
    void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            seeEnemy = true;
        }
        else
        {
            seeEnemy = false;
        }

        if (target.tag == "Ally")
        {
            seeAlly = true;
        }
        else
        {
            seeAlly = false;    
        }
    }
}
