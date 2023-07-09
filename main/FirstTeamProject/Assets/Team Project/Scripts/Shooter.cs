using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject BananaPrefab;

    private Rigidbody Bullet;
    private float delay_time = 0.2f;
    private float cool_time = default;

    void Start()
    {
        
    }

    void Update()
    {
        cool_time += Time.deltaTime;

        if (cool_time >= delay_time)
        {
            if (Input.GetKey(KeyCode.Space) == true)
            {
                GameObject Banana = Instantiate(BananaPrefab, transform.position, transform.rotation);
                Bullet = GetComponent<Rigidbody>();

                cool_time = 0;
            }
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
