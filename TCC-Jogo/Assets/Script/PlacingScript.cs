using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingScript : MonoBehaviour
{
    public SelectingManager selecting;

    bool isPlaced;
    SpriteRenderer sprite;
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
        else
        {
            sprite.color = new Color32(255, 255, 255, 0);
        }
    }
    void OnMouseDown()
    {
        if (selecting.isSelecting)
        {
            Instantiate(selecting.unitSelected, transform.position, transform.rotation);
            selecting.isSelecting = false;            
        }
    }
    void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
           
        }        
    }
    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
           
        }
    }
    void Highlighting()
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
        sprite.color = new Color32(255, 255, 255, (byte)alphaVal);
    }
}
