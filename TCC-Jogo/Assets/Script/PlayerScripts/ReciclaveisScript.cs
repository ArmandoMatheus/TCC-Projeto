using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciclaveisScript : MonoBehaviour
{
    public GameObject lootSpawn;
    public Transform lootPosition;
    public float lootTimer;
    public float initialLootTimer;

    void Start()
    {
        
    }
    void Update()
    {
        lootTimer -= Time.deltaTime;
        if(lootTimer <= 0)
        {
            Instantiate(lootSpawn, lootPosition.position, lootPosition.rotation);
            lootTimer = initialLootTimer;
        }
    }
}
