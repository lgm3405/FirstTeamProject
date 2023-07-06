using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody EnemySpawner3Rigidbody;
    void Start()
    {
        EnemySpawner3Rigidbody = GetComponent<Rigidbody>();
        EnemySpawner3Rigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 10f);
    }

    void Update()
    {
        
    }
}
