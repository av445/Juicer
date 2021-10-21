using UnityEngine;
using System.Collections;

public class MouseLooks: MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorTexture2;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public GameObject trail;
    
    //this makes it so when you press the cool mouse button the curser gets replaised with a JPG'
    public void coolmouse()
    {
        trail.SetActive(true);
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    //this reverts it to its normal state
    public void uncoolmouse()
    {
        trail.SetActive(false);
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
    public void NormalMouse()
    {
        trail.SetActive(false);
        Cursor.SetCursor(cursorTexture2, hotSpot, cursorMode);
    }

    public void Start()
    {
        trail.SetActive(false);
    }
}