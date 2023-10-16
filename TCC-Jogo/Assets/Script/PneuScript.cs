using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PneuScript : MonoBehaviour
{
    public float pneuHP;
    public GameObject[] pneuTrashLoot;
    private bool isSlashed;
    public float pneuFowardSpeed;
    public float pneuBackwardSpeed;
    float retreatTime;
    float moveTimer;
    bool isRetreating = false;

    void Update()
    {
        if (isSlashed)
        {
            pneuHP -= Time.deltaTime * 5;
        }
        if(moveTimer < 0)
        {
            Move();
        }
        if (isRetreating)
        {
            Retreat();
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet")
        {
            pneuHP--;
        }
        if (target.tag == "Ally")
        {
            float retreatTime = 2f;
        }
        if (target.tag == "Base" || target.tag == "Lixeira")
        {
            Die();
        }
        if (target.tag == "Tijolo")
        {
            isSlashed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Tijolo")
        {
            isSlashed = false;
        }
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.x -= pneuFowardSpeed * Time.deltaTime;
        transform.position = temp;
    }
    void Retreat()
    {
        if (retreatTime >= 0)
        {
            Vector3 temp = transform.position;
            temp.x += pneuBackwardSpeed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            isRetreating = false;
            moveTimer = 2f;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
