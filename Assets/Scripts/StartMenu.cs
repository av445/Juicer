using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Animator options;
    public Animator menu;
    public Animator controls;
    

    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame() 
    {
        Application.Quit();
    }
    public void Options()
    {
        options.SetTrigger("ToOptions");
    }
    public void BackToMenu()
    {
        menu.SetTrigger("ToMenu");
    }
    public void Controls()
    {
        controls.SetTrigger("ToControls");
    }
}
