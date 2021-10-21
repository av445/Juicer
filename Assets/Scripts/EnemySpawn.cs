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
        Instantiate(Enemies[(int)Random.Range(0,Enemies.Length)],new Vector3(Random.Range(-8.5f,8.5f),7,0),Quaternion.identity);
    }
}
