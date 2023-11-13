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
    float moveTimer = 1f;
    bool isRetreating = false;

    bool haveModifier = false;


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

        if(pneuHP <= 0)
        {
            Die();
        }

        if(!haveModifier)
        {
            AddDifModifier();
            haveModifier = true;
        }

        moveTimer -= Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet")
        {
            pneuHP--;
        }
        if (target.tag == "Ally")
        {
            retreatTime = 2f;
            moveTimer = 4f;
            isRetreating = true;
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
            retreatTime -= Time.deltaTime;
        }
        else
        {
            isRetreating = false;
        }
    }
    void Die()
    {
        int lootNum = Random.Range(2, 3);
        for (int i = 0; i < lootNum; i++)
        {
            Instantiate(pneuTrashLoot[Random.Range(0, 4)], transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }

    void AddDifModifier()
    {
        pneuHP += DifControlScript.pneulifeVal;
        pneuFowardSpeed += DifControlScript.pneuVelVal;
        pneuBackwardSpeed += DifControlScript.pneuVelVal;
    }
}
