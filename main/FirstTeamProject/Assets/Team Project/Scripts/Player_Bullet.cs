using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{
    public float speed = default;
    public float destroy = 3;
    public bool destroy_onoff = false;

    private Rigidbody BulletRigidbody;

    void Start()
    {
        BulletRigidbody = GetComponent<Rigidbody>();
        BulletRigidbody.velocity = transform.forward * speed;

        if (destroy_onoff == true)
        {
            Destroy(gameObject, destroy);
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Enemy_Move enemy_move = other.GetComponent<Enemy_Move>();
            
            if (enemy_move != null )
            {
                enemy_move.BulletDie();
            }
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
