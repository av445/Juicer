using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MouseLooks: MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorTexture1;
    public Texture2D cursorTexture2;
    public Texture2D cursorTexture3;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public GameObject trail;

    [SerializeField] private Slider slider;

    //this makes it so when you press the cool mouse button the curser gets replaised with a JPG'
    public void coolmouse()
    {
        trail.SetActive(true);
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    //this reverts it to its normal state
    public void SetTrail()
    {
        trail.SetActive(true);
    }
    public void RemoveTrail()
    {
        trail.SetActive(false);
    }
 
    public void Start()
    {
        trail.SetActive(false);
    }
    public void SlideSkins()
    {
        if (slider.value.Equals(1))
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
        else if(slider.value.Equals(2))
        {
            Cursor.SetCursor(cursorTexture1, hotSpot, cursorMode);
        }
        else if (slider.value.Equals(3))
        {
            Cursor.SetCursor(cursorTexture2, hotSpot, cursorMode);
        }
        else if (slider.value.Equals(4))
        {
            Cursor.SetCursor(cursorTexture3, hotSpot, cursorMode);
        }
        else if (slider.value.Equals(0))
        {
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
    }
}