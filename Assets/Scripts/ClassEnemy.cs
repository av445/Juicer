using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassEnemy : MonoBehaviour
{
    Rigidbody2D rb;

    public float xSpeed;
    public float YSpeed;

    public bool canshoot;
    public float firerate;
    public float health;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        rb.velocity = new Vector2(xSpeed, YSpeed * -1);
    }

    void Die()
    {
        ScoreManager.instance.Addpoint();
        Destroy(gameObject);
    }
    public void damage()
    {
        health--;
        if(health==0)
        {
            Die();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Die();
        }
    }
}
