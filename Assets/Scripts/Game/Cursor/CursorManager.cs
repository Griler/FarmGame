using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMangaer : MonoBehaviour
{
    [SerializeField]private Texture2D cursorDefault;
    private Texture2D _texture2D;

    private void Start()
    {
        Cursor.SetCursor(cursorDefault,Vector2.zero,CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {//distance of the plane from the camera
    }
}
