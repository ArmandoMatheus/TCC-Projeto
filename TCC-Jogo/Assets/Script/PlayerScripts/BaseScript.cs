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
    
    void Start()
    {
        baseHP = initialBaseHP;
    }
    void Update()
    {
        if (baseHP < initialBaseHP)
        {
            baseHP += healing;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            baseHP -= 1f;
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
