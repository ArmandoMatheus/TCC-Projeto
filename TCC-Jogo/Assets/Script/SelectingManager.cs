using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingManager : MonoBehaviour
{
    public GameObject[] unitOptions;
    public GameObject unitSelected;
    void Start()
    {
        
    }

    public void Select1()
    {
        unitSelected = unitOptions[0];
    }

    public void Select2()
    {
        unitSelected = unitOptions[1];
    }

    public void Select3()
    {
        unitSelected = unitOptions[2];
    }

    public void Select4()
    {
        unitSelected = unitOptions[3];
    }

    public void Select5()
    {
        unitSelected = unitOptions[4];
    }
}
