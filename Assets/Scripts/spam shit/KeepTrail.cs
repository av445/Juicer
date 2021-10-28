using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTrail : MonoBehaviour
{
    public static KeepTrail Instance;

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
