using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public GameObject DeatEffekt;

    public int health; // hur mycket hj�rtan man har
    public int nrHearts = 10; // hur m�nga hj�rtan som finns - Thea och Noa

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    // bilderna av hj�rtanen som visas och spritsens f�r hj�rtanen - Thea och Noa

    private void Start()
    {
        health = 10; //man startar spelet med 10 hj�rtan - Thea och Noa
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

            if (i < health) // om i �r mindre �n h�lsan s� visas det antalet hj�rtan som fyllda resten visas som tomma - Thea och Noa
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if( i < nrHearts) // best�mmer hur m�nga hj�rtan som finns -Thea och Noa
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

    public void OnCollisionEnter2D(Collision2D collision) // om man kolliderar med en fiende med enemy tagen s� minskar ens liv -Noa och Thea
    {
        if (collision.transform.tag == "Enemy")
        {
            health -= 1; 
        }
    }

}


