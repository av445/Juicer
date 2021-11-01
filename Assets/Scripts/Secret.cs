using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret : MonoBehaviour
{
    //This is my script for my litle secret... no peaking ;D

    //These 
    public GameObject camera1;
    public GameObject camera2;

    public void Start()
    {
        camera2.SetActive(false);
    }
    public void Textsecret()
    {
        camera2.SetActive(true);
        camera1.SetActive(false);
    }
}
