﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    //Vector2 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");// Gör så att spelaren kan röra sig Horizontalt
        movement.y = Input.GetAxisRaw("Vertical");// Får spelaren att kuna röra sig Verticalt
        

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //Vector2 lookDir = mousePos - rb.position;
       // float angel = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = angel;
    }
    //:-Hjalmar Heike//
}
