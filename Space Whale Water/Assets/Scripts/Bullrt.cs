using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullrt : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}