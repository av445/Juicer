using UnityEngine;
using System.Collections;

public class MouseLooks: MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    

    public void coolmouse()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    public void uncoolmouse()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}