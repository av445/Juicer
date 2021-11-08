using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassEnemy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject EnemyBullet;

    public float xSpeed;
    public float YSpeed;

    public bool canshoot;
    public float firerate;
    public float health;

    public Transform firepoint;

   public float bulletForce = -20f; //kraften p� kullan

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // skafar rifgidbody
    }
    void Start() // startar
    {
        if (!canshoot) return;
        firerate = firerate + (Random.Range(firerate / -2, firerate / 2)); // hur snabbt den skjuter
        InvokeRepeating("shoot", firerate, firerate); // repeterar
        
    }

   
    void Update()
    {
        rb.velocity = new Vector2(xSpeed, YSpeed * -1);
        
    }

    void Die() //n�r fienden d�r
    {
        ScoreManager.instance.Addpoint(); // l�ger till ett p��ng till highscore
        Destroy(gameObject); // f�rst�r fienden
    }
    void destory() //f�rst�r firenden
    {
        Destroy(gameObject); // f�rst�r fienden
    }
    public void damage() //n�r tar skada
    {
        health--; // liv
        if(health==0) // n�r livet blir noll d�
        {
            Die();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) //om den r�r vid en trigger
    {
        if (collision.tag == "Destroy") //startar destroy
        {
            destory(); // startar destroy
        }
    }
    void shoot()
    {
        //temp.GetComponent<EnemyBullet>().ChangeDirection();
            GameObject Bullet = Instantiate(EnemyBullet, firepoint.position, firepoint.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        
      
       
        Debug.Log("Shooting");
  
    }
} 
//Ludvig och Hjalmar