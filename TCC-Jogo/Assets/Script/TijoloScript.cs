using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TijoloScript : MonoBehaviour
{
    public float tijoloHP;
    public bool isSlashing = false;

    // Update is called once per frame
    void Update()
    {
        if (isSlashing)
        {
            tijoloHP -= Time.deltaTime;
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
            isSlashing = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            Debug.Log("detecrtantopd");
            isSlashing = false;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
