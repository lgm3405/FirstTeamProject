using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject Enemy1Prefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private float spawnRate;
    private float timeAfterSpawn;
    private int spawnLocation;
    private int spawnType;

    void Start()
    {
        timeAfterSpawn = 0f;

        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        spawnLocation = Random.Range(1, 7);
        spawnType = Random.Range(1, 6);
    }

    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;
            if (spawnLocation == 1)
            {

            }
            GameObject Enemy = Instantiate(Enemy1Prefab, transform.position, transform.rotation);
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
