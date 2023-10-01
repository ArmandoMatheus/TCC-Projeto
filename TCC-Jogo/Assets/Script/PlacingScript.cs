using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingScript : MonoBehaviour
{
    public SelectingManager selecting;

    public bool isPlaced;
    SpriteRenderer sprite;
    public Color32 rColor;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(selecting.isSelecting == true && !isPlaced)
        {
            Highlight();
        }
        else
        {
            sprite.color = new Color32(255, 255, 255, 0);
        }
    }
    void OnMouseDown()
    {
        if (selecting.isSelecting && !isPlaced)
        {
            Instantiate(selecting.unitSelected, transform.position, transform.rotation);
            selecting.isSelecting = false;
            isPlaced = true;
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
            Debug.Log("Detectado");
        }        
    }
    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Ally")
        {
            Debug.Log("saiu");
            isPlaced = false;
        }
    }
    void Highlight()
    {
        sprite.color = new Color32(255, 255, 255, (byte)selecting.alphaVal);
    }
}
