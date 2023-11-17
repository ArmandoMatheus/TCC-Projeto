using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashManager : MonoBehaviour
{
    public static int metalN = 5, vidroN = 5, papelN = 5, plasticoN = 5;
    public TMP_Text metalText, vidroText, papelText, plasticoText;
    void Start()
    {
        
    }
    void Update()
    {        
        UpdateValues();            
    }
    public void UpdateValues()
    {
        metalText.text = metalN.ToString();
        vidroText.text = vidroN.ToString();
        papelText.text = papelN.ToString();
        plasticoText.text = plasticoN.ToString();
    }    
}
