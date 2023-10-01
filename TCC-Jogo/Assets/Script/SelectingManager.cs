using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingManager : MonoBehaviour
{
    public GameObject[] unitOptions;
    public GameObject unitSelected;
    public bool isSelecting = false;
    public int alphaVal;
    bool alphaMin = false;

    void Update()
    {
        if (isSelecting)
        {
            if (alphaMin)
            {
                alphaVal += 4;
                if (alphaVal >= 200)
                    alphaMin = false;
            }
            if (!alphaMin)
            {
                alphaVal -= 4;
                if (alphaVal <= 0)
                    alphaMin = true;
            }
        }
        else
        {
            alphaVal = 0;
        }     
    }
    public void Select1()
    {
        unitSelected = unitOptions[0];
        isSelecting = true;
    }

    public void Select2()
    {
        unitSelected = unitOptions[1];
        isSelecting = true;
    }

    public void Select3()
    {
        unitSelected = unitOptions[2];
        isSelecting = true;
    }

    public void Select4()
    {
        unitSelected = unitOptions[3];
        isSelecting = true;
    }

    public void Select5()
    {
        unitSelected = unitOptions[4];
        isSelecting = true;
    }
}
