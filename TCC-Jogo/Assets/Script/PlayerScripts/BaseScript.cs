using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseScript : MonoBehaviour
{
    public float baseHP;
    public float healing;
    public float initialBaseHP;

    public HealthBarScript healthBar;
    public GameManager manager;    
    void Start()
    {
        baseHP = initialBaseHP;
        healthBar.SetMaxHealth(initialBaseHP);
    }
    void Update()
    {
        if (baseHP < initialBaseHP)
        {
            baseHP += healing;
            healthBar.SetHealth(baseHP);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy" || col.tag == "Pneu")
        {
            baseHP--;
            healthBar.SetHealth(baseHP);
            if (baseHP <= 0)
            {
                manager.GameLose();
            }
        }
    }   
}
