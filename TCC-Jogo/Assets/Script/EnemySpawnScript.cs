using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject[] enemyPool;
    public Transform[] enemyPos;

    public float timer = 4f;

    void Start()
    {
        Invoke("Spawn", timer);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(enemyPool[Random.Range(0, enemyPool.Length)], enemyPos[Random.Range(0, enemyPos.Length)].transform.position, Quaternion.identity);

        Invoke("Spawn", timer);
    }
}

    
