using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCurser2 : MonoBehaviour
{
    //This code makes it so that the mouse model is not destried when you go to another scene
    public static KeepCurser2 Instance;

    private void Start()
    {
        //this if makes it so that if you return to the same scene there wont be 2 models but only 1
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
