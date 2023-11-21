using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectingManager : MonoBehaviour
{
    public GameObject[] unitOptions;
    public GameObject unitSelected;
    public bool isSelecting = false;
    public int alphaVal;
    bool alphaMin = false;
    public int pVidro, pMetal, pPapel, pPlastico;
    public TMP_Text pVidroText, pMetalText, pPapelText, pPlasticoText;

    public GameObject reciclavelSelectWindow;

    private void Start()
    {
        reciclavelSelectWindow.SetActive(false);
    }

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
        if (TrashManager.vidroN >= 1 && TrashManager.plasticoN >= 1 && TrashManager.papelN >= 1)
        {
            unitSelected = unitOptions[0];
            isSelecting = true;
            pVidro = 1;
            pMetal = 0;
            pPapel = 1;
            pPlastico = 1;
            AttText();
            reciclavelSelectWindow.SetActive(false);
        }
    }
    public void Select2()
    {
        if (TrashManager.metalN >= 2 && TrashManager.plasticoN >= 1)
        {
            unitSelected = unitOptions[1];
            isSelecting = true;
            pVidro = 0;
            pMetal = 2;
            pPapel = 0;
            pPlastico = 1;
            AttText();
            reciclavelSelectWindow.SetActive(false);
        }
    }
    public void Select3()
    {
        if (TrashManager.vidroN >= 1 && TrashManager.papelN >= 1 && TrashManager.metalN >= 1)
        {
            unitSelected = unitOptions[2];
            isSelecting = true;
            pVidro = 1;
            pMetal = 1;
            pPapel = 1;
            pPlastico = 0;
            AttText();
            reciclavelSelectWindow.SetActive(false);
        }
    }
    public void Select4()
    {
        if (TrashManager.plasticoN >= 1 && TrashManager.metalN >= 1 && TrashManager.papelN >= 1)
        {
            unitSelected = unitOptions[3];
            isSelecting = true;
            pVidro = 0;
            pMetal = 1;
            pPapel = 1;
            pPlastico = 1;
            AttText();
            reciclavelSelectWindow.SetActive(false);
        }
    }
    public void Select5()
    {
        
        reciclavelSelectWindow.SetActive(true);
        isSelecting = true;
        
    }
    public void Select5_1()
    {
        if (TrashManager.vidroN >= 1 && TrashManager.papelN >= 1 && TrashManager.metalN >= 1)
        {
            unitSelected = unitOptions[4];
            isSelecting = true;
            reciclavelSelectWindow.SetActive(false);
            pVidro = 1;
            pMetal = 1;
            pPapel = 1;
            pPlastico = 0;
            AttText();
        }
    }
    public void Select5_2()
    {
        if (TrashManager.vidroN >= 1 && TrashManager.papelN >= 1 && TrashManager.plasticoN >= 1)
        {
            unitSelected = unitOptions[5];
            isSelecting = true;
            reciclavelSelectWindow.SetActive(false);
            pVidro = 1;
            pMetal = 0;
            pPapel = 1;
            pPlastico = 1;
            AttText();
        }
    }
    public void Select5_3()
    {
        if (TrashManager.vidroN >= 1 && TrashManager.plasticoN >= 1 && TrashManager.metalN >= 1)
        {
            unitSelected = unitOptions[6];
            isSelecting = true;
            reciclavelSelectWindow.SetActive(false);
            pVidro = 1;
            pMetal = 1;
            pPapel = 0;
            pPlastico = 1;
            AttText();
        }
    }
    public void Select5_4()
    {
        if (TrashManager.plasticoN >= 1 && TrashManager.papelN >= 1 && TrashManager.metalN >= 1)
        {
            unitSelected = unitOptions[7];
            isSelecting = true;
            reciclavelSelectWindow.SetActive(false);
            pVidro = 0;
            pMetal = 1;
            pPapel = 1;
            pPlastico = 1;
            AttText();
        }
    }
    public void CancelSelect()
    {
        isSelecting = false;
        reciclavelSelectWindow.SetActive(false);
        pVidro = 0;
        pMetal = 0;
        pPapel = 0;
        pPlastico = 0;
        AttText();
    }
    public void Pay()
    {
        TrashManager.metalN -= pMetal;
        TrashManager.vidroN -= pVidro;
        TrashManager.papelN -= pPapel;
        TrashManager.plasticoN -= pPlastico;
    }
    void AttText()
    {
        pVidroText.text = pVidro.ToString();
        pMetalText.text = pMetal.ToString();
        pPapelText.text = pPapel.ToString();
        pPlasticoText.text = pPlastico.ToString();
    }
}
