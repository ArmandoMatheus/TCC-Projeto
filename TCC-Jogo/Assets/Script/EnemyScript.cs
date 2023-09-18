using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   

    public float enemyHP;
    public float enemySpeed = 2f;
    public bool canBeHit;

    void Start()
    {
      
    }
       
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.x -= enemySpeed * Time.deltaTime;
        transform.position = temp;
    }
}
