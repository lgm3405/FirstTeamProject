using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public float speed = default;
    public GameObject EnemyEffectPrefab;
    public GameObject LineEffectPrefab;

    private Rigidbody EnemyRigidbody;
    private Rigidbody EnemyEffectRigidbody;
    private Rigidbody LineEffectRigidbody;

    void Start()
    {
        EnemyRigidbody = GetComponent<Rigidbody>();
        EnemyEffectRigidbody = GetComponent<Rigidbody>();
        LineEffectRigidbody = GetComponent<Rigidbody>();

        EnemyRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 30f);
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

        GameObject enemy_effect = Instantiate(EnemyEffectPrefab, transform.position, transform.rotation);
        Destroy(gameObject, 3f);
    }

    public void LineDie()
    {
        GameManager gamemanager = FindObjectOfType<GameManager>();
        gamemanager.LifeDown();

        gameObject.SetActive(false);

        GameObject line_effect = Instantiate(LineEffectPrefab, transform.position, transform.rotation);
        Destroy(gameObject, 3f);
    }
}
