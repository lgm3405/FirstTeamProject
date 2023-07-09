using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject Enemy1Prefab;
    public GameObject Enemy2Prefab;
    public GameObject Enemy3Prefab;
    public GameObject Enemy4Prefab;
    public GameObject Enemy5Prefab;

    private float spawnRateMin = 1f;
    private float spawnRateMax = 5f;
    private float spawnRate;
    private float timeAfterSpawn;
    private int spawnType;

    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        spawnType = Random.Range(1, 6);
    }

    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;
            if (spawnType == 1)
            {
                GameObject Enemy1 = Instantiate(Enemy1Prefab, transform.position, transform.rotation);
            }
            else if (spawnType == 2)
            {
                GameObject Enemy2 = Instantiate(Enemy2Prefab, transform.position, transform.rotation);

            }
            else if (spawnType == 3)
            {
                GameObject Enemy3 = Instantiate(Enemy3Prefab, transform.position, transform.rotation);

            }
            else if (spawnType == 4)
            {
                GameObject Enemy4 = Instantiate(Enemy4Prefab, transform.position, transform.rotation);

            }
            else if (spawnType == 5)
            {
                GameObject Enemy5 = Instantiate(Enemy5Prefab, transform.position, transform.rotation);
            }

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
            spawnType = Random.Range(1, 6);
        }
    }
}
