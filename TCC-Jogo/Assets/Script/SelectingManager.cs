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
    public int pVidro, pMetal, pPapel, pPlastico;

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
        if (TrashManager.vidroN >= 3 && TrashManager.plasticoN >= 2)
        {
            unitSelected = unitOptions[0];
            isSelecting = true;
            pVidro = 1;
            pMetal = 0;
            pPapel = 2;
            pPlastico = 2;
        }
    }

    public void Select2()
    {
        if (TrashManager.metalN >= 4 && TrashManager.plasticoN >= 1)
        {
            unitSelected = unitOptions[1];
            isSelecting = true;
            pVidro = 0;
            pMetal = 3;
            pPapel = 1;
            pPlastico = 1;
        }
    }

    public void Select3()
    {
        if (TrashManager.vidroN >= 2 && TrashManager.papelN >= 3)
        {
            unitSelected = unitOptions[2];
            isSelecting = true;
            pVidro = 2;
            pMetal = 0;
            pPapel = 2;
            pPlastico = 1;
        }
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

    public void Pay()
    {
        TrashManager.metalN -= pMetal;
        TrashManager.vidroN -= pVidro;
        TrashManager.papelN -= pPapel;
        TrashManager.plasticoN -= pPlastico;
    }
}
