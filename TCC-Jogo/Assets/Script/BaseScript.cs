using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseScript : MonoBehaviour
{
    public int baseHP;
    public int healing;

    public GameObject GameOverPanel;
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            baseHP--;
            if(baseHP <= 0)
            {
                GameOver();
            }
        }
    }
    void GameOver()
    {
        GameOverPanel.SetActive(true);
        Debug.Log("Game Over");
    }
}
