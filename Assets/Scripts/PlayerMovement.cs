using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public Animator Doge;

    Vector2 movement;
    

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");// Gör så att spelaren kan röra sig Horizontalt
        movement.y = Input.GetAxisRaw("Vertical");// Får spelaren att kuna röra sig Verticalt

        if (Input.GetKeyDown(KeyCode.E))
        {
            Doge.SetTrigger("Dodge");
        }
       
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    //:-Hjalmar Heike//
}
