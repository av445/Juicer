using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    //this is so I can activate the secret
    public GameObject secret;

    //these are just name to trigger animations 
    public Animator options;
    public Animator MenuToOption;

    public Animator Controls;
    public Animator ControlsToMenu;

    //this makes it so I can replaise the menu text
    public GameObject Asteroids;
    public GameObject Assdestyers;

    //This is to store the input fields stuff
    public string assCode;
    public GameObject inputField;

    // this sets the camera to a desired size so that the buttons don't fuck up
    public void Start()
    {
        int cameraHeight = 8;
        float desiredAspect = 16f / 9f;
        float aspect = Camera.main.aspect;
        float ratio = desiredAspect / aspect;
        Camera.main.orthographicSize = cameraHeight * ratio;

        Assdestyers.SetActive(false);
        secret.SetActive(false);
    }
    public void Ass()
    {
        //this makes it so if you put in ass in the text box the title screan changes and some secrets opens up... I didn't pick the name ok
        assCode = inputField.GetComponent<Text>().text;
        if(assCode == "ass")
        {
            Asteroids.SetActive(false);
            Assdestyers.SetActive(true);
            secret.SetActive(true);
        }
    }
    //this loads the begining scene
    public void start()
    {
        if (assCode == "ass")
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
    //this quits the game
    public void Quite()
    {
        Application.Quit();
    }
    //this one and down starts an animation that moves the camera to a diferent part of the menu
    public void Options()
    {
        options.SetTrigger("ToOptions");
    }
    public void MenuToOptions()
    {
        MenuToOption.SetTrigger("MenuToOptions");
    }

    public void Controlls()
    {
        Controls.SetTrigger("Controlls");
    }
    public void MenuToControlls()
    {
        ControlsToMenu.SetTrigger("ControllsToMenu");
    }
    //shhh secret room
    public void Secret()
    {
        SceneManager.LoadScene("I'mNotHere");
    }
}
