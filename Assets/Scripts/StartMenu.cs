using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Animator options;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void Options()
    {
        options.SetTrigger("options");
    }
    public void QuitGame() 
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
        
    }
}
