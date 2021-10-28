using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{

    public int health;
    public int nrHarts;

    public Image[] harts;
    public Sprite fullHart;
    public Sprite emptyHart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < harts.Length; i++)
        {
            if( i < nrHarts)
            {
                harts[i].enabled = true;
            }
            else
            {
                harts[i].enabled = false;
            }
        }


    }
}
