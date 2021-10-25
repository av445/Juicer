using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public float WaitTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemyspawn());
    }

  IEnumerator Enemyspawn()
    {
        while(true)
        {
            Vector3 enemyspawn = new Vector3(Random.Range(-8, 8f), 7f, 0);
            Instantiate(enemy, enemyspawn, Quaternion.identity);
            yield return new WaitForSeconds(WaitTime);
        }
    }
}
//Ludvig