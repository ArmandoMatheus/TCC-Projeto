using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamageScript : MonoBehaviour
{
    
    public void GetDamage(SpriteRenderer spriteRenderer, float DamTimer)
    {
        spriteRenderer.color = new Color32(255,0,0,255);
        DamTimer = 5.5f;
        while(DamTimer > 0)
        {            
            DamTimer--;
            if (DamTimer > 1)
                return;
            
            spriteRenderer.color = new Color32(255, 255, 255, 255);
        }
    }
}
