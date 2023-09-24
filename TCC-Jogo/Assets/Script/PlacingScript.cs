using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingScript : MonoBehaviour
{
    public SelectingManager selecting;
    bool canPlace;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Instantiate(selecting.unitSelected, transform.position, transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
            canPlace = true;
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
            canPlace = false;
        }
    }

    //OnMousseClick instantiate the SELECTED - the SELECTED is defined in the character selection 
}
