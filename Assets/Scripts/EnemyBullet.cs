using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject hiteffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<ClassEnemy>().damage();
        }


    }
  //  internal void ChangeDirection()
   // {
   //     throw new NotImplementedException();
  //  }
}
