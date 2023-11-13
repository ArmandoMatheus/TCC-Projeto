using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifControlScript : MonoBehaviour
{
    public float timerVal; 

    public static float pneulifeVal, enemylifeVal;
    public static float pneuVelVal, enemyVelVal;
    public static float pneuDamVal, enemyDamVal;

    public static int lootNum;

    public int difLevel = 0;

    public GameObject selectDifWindow;
    public EnemySpawnScript spawn;

    public void SetDificulty()
    {
        if(difLevel == 1)
        {
            timerVal = 8;
            pneulifeVal = -2; enemylifeVal = -2;
            pneuVelVal = -1; enemyVelVal = -1;
            pneuDamVal = 1; enemyDamVal = .5f;
        }
        if (difLevel == 2)
        {
            timerVal = 6;
            pneulifeVal = 0; enemylifeVal = 0;
            pneuVelVal = 0; enemyVelVal = 0;
            pneuDamVal = 2; enemyDamVal = 1;
        }
        if (difLevel == 3)
        {
            timerVal = 4;
            pneulifeVal = 1; enemylifeVal = 1;
            pneuVelVal = 1; enemyVelVal = 1;
            pneuDamVal = 3; enemyDamVal = 1.5f;
        }
        if (difLevel == 4)
        {
            timerVal = 3;
            pneulifeVal = 3; enemylifeVal = 2;
            pneuVelVal = 2; enemyVelVal = 2;
            pneuDamVal = 4; enemyDamVal = 2;
        }
        selectDifWindow.SetActive(false);
        spawn.StartSpawn();
    }
    public void Dificulty1()
    {
        difLevel = 1;
        SetDificulty();
        
    }
    public void Dificulty2()
    {
        difLevel = 2;
        SetDificulty();
       
    }
    public void Dificulty3()
    {
        difLevel = 3;
        SetDificulty();
        
    }
    public void Dificulty4()
    {
        difLevel = 4;
        SetDificulty();
        
    }
}
