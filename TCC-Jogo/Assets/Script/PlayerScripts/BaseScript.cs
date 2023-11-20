using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseScript : MonoBehaviour
{
    public float baseHP;
    public float healing;
    public float initialBaseHP;

    public GameObject GameOverPanel;

    public HealthBarScript healthBar;
    
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
            baseHP -= 1f;
            healthBar.SetHealth(baseHP);
            if (baseHP <= 0)
            {
                GameOver();
            }
        }
    }
    void GameOver()
    {
        TrashManager.plasticoN = 5;
        TrashManager.vidroN = 5;
        TrashManager.papelN = 5;
        TrashManager.metalN = 5;
        GameOverPanel.SetActive(true);
        Debug.Log("Game Over");
    }
}
