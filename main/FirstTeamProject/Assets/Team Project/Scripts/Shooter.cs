using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject BananaPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            GameObject Banana = Instantiate(BananaPrefab, transform.position, transform.rotation);
        }
    }
}
