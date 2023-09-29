using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    public float attSpeed;
    public float attDestroyTimer;
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
        temp.x -= attSpeed * Time.deltaTime;
        transform.position = temp;
        attDestroyTimer -= Time.deltaTime;

        if (attDestroyTimer <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
            Destroy(gameObject);
        }
    }
}
