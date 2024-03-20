using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LandItem : MonoBehaviour
{
    public bool hasPlant = false;
    public bool isUnlock = false;
    //[SerializeField] private GameObject background;    
    private void Awake()
    {
        show();
    }
    // Update is called once per frame
    void show()
    {
        setUnlockLand();
    }

    void setUnlockLand()
    {
        SpriteRenderer tilemap = gameObject.GetComponent<SpriteRenderer>();
        if (isUnlock)
        {
            tilemap.color = Color.white;
        }
        else
        {
            tilemap.color = Color.gray;

        }
    }
    void OnMouseOver()
    {
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is no longer on GameObject.");
    }
}
