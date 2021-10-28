using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float rate;
    public GameObject[] Enemies;
    public int wave;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", rate, rate);   
    }

    void SpawnEnemy()
    {
        for (int i = 0; i < wave; i++);
        Instantiate(Enemies[(int)Random.Range(0,Enemies.Length)],new Vector3(Random.Range(-20f,20f),10,0),Quaternion.identity);
    }
}
