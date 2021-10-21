using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHunter : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 Movement;
    
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcktion = player.position - transform.position;
        float angel = Mathf.Atan2(direcktion.y, direcktion.x) * Mathf.Rad2Deg;
        rb.rotation = angel + 90;
        direcktion = direcktion.normalized;
       
        Movement = direcktion;
    }
    private void FixedUpdate()
    {
        movecharater(Movement);
    }
    void movecharater(Vector2 direcktion)
    {
        rb.MovePosition(rb.position + direcktion * moveSpeed * Time.deltaTime);
    }
}
