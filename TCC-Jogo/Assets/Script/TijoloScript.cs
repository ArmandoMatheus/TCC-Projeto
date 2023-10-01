using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TijoloScript : MonoBehaviour
{
    public float tijoloHP;
      

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            tijoloHP -= Time.deltaTime * 0.5f;
            if(tijoloHP < 0)
            {
                Die();
            }
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
