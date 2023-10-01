using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    public int baseHP;
    public int healing;
    
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
        Debug.Log("Game Over");
    }
}
