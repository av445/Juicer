using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Secret : MonoBehaviour
{
    //This is my script for my litle secret... no peaking ;D

    //These make it so I can change to another camera
    public GameObject camera1;
    public GameObject camera2;

    public Animator Shhh;

    public GameObject TheEnd;

    public bool countDownTF;
    public float countDown = 45f;
    //this makes it so the back button takes you back to the main menu
    public void back()
    {
        SceneManager.LoadScene(0);
    }

    public void Start()
    {
        TheEnd.SetActive(false);
        camera2.SetActive(false);

        countDownTF = false;
    }
    public void Textsecret()
    {
        camera2.SetActive(true);
        camera1.SetActive(false);
        Shhh.SetTrigger("Shhh");

        countDownTF = true;
    }

    public void Update()
    {
        if(countDownTF == true)
        {
            countDown -= Time.deltaTime;
        }
        if (countDown <= 1)
        {
            TheEnd.SetActive(true);
        }
    }
}
