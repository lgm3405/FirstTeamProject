using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody EnemySpawnerRigidbody;
    void Start()
    {
        EnemySpawnerRigidbody = GetComponent<Rigidbody>();
        EnemySpawnerRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 10f);
    }

    void Update()
    {
        
    }
}
