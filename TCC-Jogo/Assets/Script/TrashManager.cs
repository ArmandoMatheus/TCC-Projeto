using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashManager : MonoBehaviour
{
    public int metalN, vidroN, papelN, plasticoN;
    public TMP_Text metalText, vidroText, papelText, plasticoText;
    void Start()
    {
        
    }
    public void UpdateValues()
    {
        metalText.text = metalN.ToString();
        vidroText.text = vidroN.ToString();
        papelText.text = papelN.ToString();
        plasticoText.text = plasticoN.ToString();
    }    
}
