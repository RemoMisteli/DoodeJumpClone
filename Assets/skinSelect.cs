using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinSelect : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    // Start is called before the first frame update
    void Start()
    {
        ChangeSprite(PlayerPrefs.GetInt("skinId"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSprite(int index=0)
    {
     Debug.Log(spriteArray);
        spriteRenderer.sprite = spriteArray[index]; 
    }
}
