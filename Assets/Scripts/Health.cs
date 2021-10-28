using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{

    public int health;
    public int nrHarts;

    public GameObject[] hearts;
    public GameObject fullHart;
    public GameObject emptyHart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health > nrHarts)
        {
            health = nrHarts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {

            if (i < health)
            {
                hearts[i] = fullHart;
            }
            else
            {
                hearts[i] = emptyHart;
            }
            if( i < nrHarts)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }


    }
}
