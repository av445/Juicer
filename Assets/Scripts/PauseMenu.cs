using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    bool options;
    public void Start()
    {
        options = false;
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
            }
            else
            {
                options = false;
                Time.timeScale = 1;
            }
        }
    }
}
