using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject firstSkin;
    public GameObject seconedSkin;

    //this makes it so you can change skins
    private void Start()
    {
        seconedSkin.SetActive(false);
    }
    // this makes the sprite follows the mouse
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
    //this makes it so that the buttons can replaice the curser skins
    public void Skin1()
    {
        firstSkin.SetActive(true);
        seconedSkin.SetActive(false);
    }
    public void Skin2()
    {
        firstSkin.SetActive(false);
        seconedSkin.SetActive(true);
    }
}
