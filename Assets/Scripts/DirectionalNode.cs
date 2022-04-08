using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;
    

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = left;
        SwitchSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchSprite()
    {
        Debug.Log("Switch sprite ran");
        if(current == "left")
        {
            Debug.Log("Choose left");
            sr.sprite = left;
        }
        else if(current == "right")
        {
            Debug.Log("Choose right");
            sr.sprite = right;
        }
        else
        {
            Debug.Log("Choose none");
            sr.sprite = none;
        }
    }
}
