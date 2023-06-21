using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(transform.right * Time.deltaTime * speed, Space.World);
    }
}
