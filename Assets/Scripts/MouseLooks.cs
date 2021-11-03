using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MouseLooks: MonoBehaviour
{
    // this makes it so I can activate and de activate the trail
    public GameObject trail;

    //this adds the trail
    public void SetTrail()
    {
        trail.SetActive(true);
        GameObject.DontDestroyOnLoad(trail.gameObject);
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
}