using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret : MonoBehaviour
{
    //This is my script for my litle secret... no peaking ;D

    //These make it so I can change to another camera
    public GameObject camera1;
    public GameObject camera2;

    public Animator Shhh;

    public GameObject TheEnd;

    public float countDown = 40f;
    public void Start()
    {
        TheEnd.SetActive(false);
        camera2.SetActive(false);
    }
    public void Textsecret()
    {
        camera2.SetActive(true);
        camera1.SetActive(false);
        Shhh.SetTrigger("Shhh");

        countDown -= Time.deltaTime;
    }

    public void FixedUpdate()
    {
        if (countDown == 0)
        {
            TheEnd.SetActive(true);
        }
    }
}
