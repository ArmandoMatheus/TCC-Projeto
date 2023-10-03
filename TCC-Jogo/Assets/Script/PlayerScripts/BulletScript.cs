using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDestroyTimer;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 temp = transform.position;
        temp.x += bulletSpeed * Time.deltaTime;
        transform.position = temp;
        bulletDestroyTimer -= Time.deltaTime;

        if(bulletDestroyTimer <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Enemy")
        {
            Destroy(gameObject);
        }    
    }
}