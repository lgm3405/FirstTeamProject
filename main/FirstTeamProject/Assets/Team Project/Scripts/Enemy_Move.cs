using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public float speed = default;

    private Rigidbody EnemyRigidbody;

    void Start()
    {
        EnemyRigidbody = GetComponent<Rigidbody>();
        EnemyRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 10f);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Player_Bullet player_bullet = other.GetComponent<Player_Bullet>();

            if (player_bullet != null)
            {
                player_bullet.Die();
            }
        }
    }

    public void BulletDie()
    {
        GameManager gamemanager = FindObjectOfType<GameManager>();
        gamemanager.ScorePlus();

        gameObject.SetActive(false);
    }

    public void LineDie()
    {
        GameManager gamemanager = FindObjectOfType<GameManager>();
        gamemanager.LifeDown();

        gameObject.SetActive(false);
    }
}
