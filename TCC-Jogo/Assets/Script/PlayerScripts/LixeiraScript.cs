using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixeiraScript : MonoBehaviour
{
    public int lixeiraHP;
    void Update()
    {
        if(lixeiraHP <= 0)
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            lixeiraHP--;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
