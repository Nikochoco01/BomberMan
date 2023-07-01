using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Texture2D cursorTexture1;
    public CursorMode cursorMode1 = CursorMode.Auto;
    public Vector2 hotSpot1 = Vector2.zero;

    public Texture2D cursorTexture2;
    public CursorMode cursorMode2 = CursorMode.Auto;
    public Vector2 hotSpot2 = Vector2.zero;


    public void Cursor1()
    {
        UnityEngine.Cursor.SetCursor(cursorTexture1, hotSpot1, cursorMode1);   
    }

    public void Cursor2()
    {
        UnityEngine.Cursor.SetCursor(cursorTexture2, hotSpot2, cursorMode2);
    }

    public void Active()
    {
        UnityEngine.Cursor.visible = true;
    }

    public void Desactive()
    {
        UnityEngine.Cursor.visible = false;
    }
}
