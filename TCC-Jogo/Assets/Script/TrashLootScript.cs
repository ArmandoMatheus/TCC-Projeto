using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashLootScript : MonoBehaviour
{
    public bool isMetal, isVidro, isPapel, isPlastico;
    float moveX, moveY, timerX, timerY;
    public TrashManager trashManager;
    bool setValues = true;
    void Start()
    {
        
    }
    void Update()
    {
        Move();
        Timer();
    }
    void Move()
    {
        if (setValues)
        {
            timerX = 1f;
            timerY = 1f;
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
        { trashManager.metalN++; }
        if (isVidro)
        { trashManager.vidroN++; }
        if (isPapel)
        { trashManager.papelN++; }
        if (isPlastico)
        { trashManager.plasticoN++; }
        trashManager.UpdateValues();
        Destroy(gameObject);    
    }
}
