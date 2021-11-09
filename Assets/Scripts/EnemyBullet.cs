using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject hiteffect;
    private void OnCollisionEnter2D(Collision2D collision) // om den träffar något
    {
        GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);// träff effekten
        Destroy(effect, 0.5f); //  tar bort effekten
        Destroy(gameObject); // ta bort sig själv
        if (collision.transform.tag == "Player") // spelaren specifikt
        {
            collision.gameObject.GetComponent<ClassEnemy>().damage(); //få spelaren att ta skada
        }


    }
    private void Update()
    {
        //  internal void ChangeDirection()
        // {
        //     throw new NotImplementedException();
        //   }
    }
}
//Ludvig