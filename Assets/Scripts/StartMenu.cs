using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Animator options;
    public Animator MenuToOption;

    public Animator Controls;
    public Animator ControlsToMenu;
    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void Quite()
    {
        Application.Quit();
    }
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
