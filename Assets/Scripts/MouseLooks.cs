using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MouseLooks: MonoBehaviour
{
    /* this is where you would put your mouse models hover it was bad and scraped
    public Texture2D cursorTexture;
    public Texture2D cursorTexture1;
    public Texture2D cursorTexture2;
    public Texture2D cursorTexture3;
    */
    // this makes it so I can activate and de activate the trail
    public GameObject trail;

    //[SerializeField] private Slider slider; was gona be used but scrapt

    //this adds the trail
    public void SetTrail()
    {
        trail.SetActive(true);
    }

    //this removes the trail
    public void RemoveTrail()
    {
        trail.SetActive(false);
    }
    // this removes the cursior and the trail
    public void Start()
    {
        trail.SetActive(false);
        Cursor.visible = false;
    }
    /* this would be used to customize the mouse to look diferently hoever it waas bad
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
    */
}