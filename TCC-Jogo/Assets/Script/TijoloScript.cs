using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TijoloScript : MonoBehaviour
{
    public float tijoloHP;
    public bool isHitted = false;

    // Update is called once per frame
    void Update()
    {
        if (isHitted)
        {
            tijoloHP -= Time.deltaTime * 0.5f;
            if (tijoloHP < 0)
            {
                Die();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            Debug.Log("detecrtantopd");
            isHitted = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            Debug.Log("detecrtantopd");
            isHitted = false;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
