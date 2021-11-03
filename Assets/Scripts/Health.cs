using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public GameObject DeatEffekt;

    public int health;
    public int nrHearts = 10;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    private void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(health > nrHearts)
        {
            health = nrHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {

            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if( i < nrHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (health == 0)
        {
            GameObject effect = Instantiate(DeatEffekt, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            health -= 1; 
        }
    }

}


