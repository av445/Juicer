using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hiteffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
        
        Destroy(effect, 0.5f);
        Destroy(gameObject);
        if (collision.transform.tag == "Enemy"|| collision.transform.tag == "Enemy bullet")
        {
            collision.gameObject.GetComponent<ClassEnemy>().damage();
        }
        


    }
    
}
