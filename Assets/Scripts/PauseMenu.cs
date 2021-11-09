using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    bool options;
    public void Start()
    {
        options = false;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (options == false)
            {
                options = true;
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
            else
            {
                options = false;
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
        }
    }

    public void start()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void exit()
    {
        Application.Quit();
    }
}
