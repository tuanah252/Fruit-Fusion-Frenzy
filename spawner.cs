using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject core;
    public float spawnInterval = 3f;
    public int spawnCount = 5;
    public Transform target; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnInterval, spawnInterval);
    }

    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject obj = Instantiate(prefab, target.position, Quaternion.identity);
        }
    }
}
