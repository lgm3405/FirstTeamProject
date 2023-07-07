using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Line : MonoBehaviour
{
    private Rigidbody FinishRigidbody;

    void Start()
    {
        FinishRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Enemy_Move enemy_move = other.GetComponent<Enemy_Move>();

            if (enemy_move != null)
            {
                enemy_move.LineDie();
            }
        }
    }
}
