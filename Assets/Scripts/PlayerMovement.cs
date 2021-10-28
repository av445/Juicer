using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using EZCameraShake;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public Animator Doge;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");// Gör så att spelaren kan röra sig Horizontalt
        movement.y = Input.GetAxisRaw("Vertical");// Får spelaren att kuna röra sig Verticalt

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Doge.SetTrigger("Dodge");
            moveSpeed = 15f;
            Invoke("ResetSpeed", 1);
        }
        
       
    }

    void ResetSpeed()
    {
        moveSpeed = 10f;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angel = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angel;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        }
       
    }
    //:-Hjalmar Heike//
}
