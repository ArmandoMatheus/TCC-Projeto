using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject[] enemyPool;
    public Transform[] enemyPos;
    public DifControlScript difScript;

    public float timer;

    public void StartSpawn()
    {
        timer = difScript.timerVal;
        float initialTimer = 2f;
        Invoke("Spawn", initialTimer);
    }

    void Spawn()
    {
        Instantiate(enemyPool[Random.Range(0, enemyPool.Length)], enemyPos[Random.Range(0, enemyPos.Length)].transform.position, Quaternion.identity);

        Invoke("Spawn", timer);
    }

    private void Update()
    {
        if (timer > 2f)
        {
            timer -= Time.deltaTime * .010f;
        }
    }
}

    
