using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject BananaPrefab;

    private Rigidbody Bullet;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            GameObject Banana = Instantiate(BananaPrefab, transform.position, transform.rotation);
            Bullet = GetComponent<Rigidbody>();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
