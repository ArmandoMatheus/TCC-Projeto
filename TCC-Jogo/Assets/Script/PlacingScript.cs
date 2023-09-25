using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingScript : MonoBehaviour
{
    public SelectingManager selecting;
    bool canPlace;

    private SpriteRenderer sprite;
    public Color32 rColor;
    public int alphaVal;
    bool alphaMin = false;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(selecting.isSelecting == true)
        {
            Highlighting();
        } 
    }

    void OnMouseDown()
    {
        if (selecting.isSelecting == true)
        {
            Instantiate(selecting.unitSelected, transform.position, transform.rotation);
            selecting.isSelecting = false;
            sprite.color = new Color32(255, 255, 255, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
            canPlace = false;
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
            canPlace = true;
        }
    }
    void Highlighting()
    {
        if (alphaMin == true)
        {
            alphaVal = alphaVal +2;
            if (alphaVal == 200)
                alphaMin = false;
        }
        if (alphaMin == false)
        {
            alphaVal = alphaVal - 2;
            if (alphaVal == 0)
                alphaMin = true;
        }
       
        sprite.color = new Color32(255, 255, 255, (byte)alphaVal);        

        }
}
