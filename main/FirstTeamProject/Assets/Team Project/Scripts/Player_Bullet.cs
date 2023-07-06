using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody PlayerRigidbody;
    
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
        PlayerRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 5f);
    }

    void Update()
    {
        
    }
}
