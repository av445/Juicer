using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    //these are just name to trigger animations 
    public Animator options;
    public Animator MenuToOption;

    public Animator Controls;
    public Animator ControlsToMenu;
    public void Start()
    {
        int cameraHeight = 8;
        float desiredAspect = 16f / 9f;
        float aspect = Camera.main.aspect;
        float ratio = desiredAspect / aspect;
        Camera.main.orthographicSize = cameraHeight * ratio;
    }
    //this loads the begining scene
    public void start()
    {
        SceneManager.LoadScene(1);
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
}
