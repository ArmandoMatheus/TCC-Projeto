using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashLootScript : MonoBehaviour
{
    public bool isMetal, isVidro, isPapel, isPlastico;
    float moveX, moveY, timerX = 1f, timerY = 1f;
    bool setValues = true;
    void Update()
    {
        Move();
        Timer();
    }
    void Move()
    {
        if (setValues)
        {
            moveX = Random.Range(-.5f, .5f);
            moveY = Random.Range(-.5f, .5f);
            setValues = false;
        }
        Vector3 temp = transform.position;
        if(timerX > 0)
        {   
            temp.x += Time.deltaTime * moveX;
        }
        if(timerY > 0)
        {
            temp.y += Time.deltaTime * moveY;
        }
        transform.position = temp;
    }
    void Timer()
    {
        timerX -= Time.deltaTime;
        timerY -= Time.deltaTime;
    }

    void OnMouseDown()
    {
        if (isMetal)
        { TrashManager.metalN++; }
        if (isVidro)
        { TrashManager.vidroN++; }
        if (isPapel)
        { TrashManager.papelN++; }
        if (isPlastico)
        { TrashManager.plasticoN++; }
        Destroy(gameObject);    
    }
}
