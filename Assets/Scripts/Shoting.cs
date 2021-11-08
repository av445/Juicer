using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public Transform firepoint;
    public Transform firepoint1;
    public GameObject BulletPrefab;

    public AudioClip shoots;

    public float bulletForce = 20f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
        }
    }
    void shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
        GameObject Bollet = Instantiate(BulletPrefab, firepoint1.position, firepoint1.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        Rigidbody2D rB = Bollet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        rB.AddForce(firepoint1.up * bulletForce, ForceMode2D.Impulse);
    }
}

