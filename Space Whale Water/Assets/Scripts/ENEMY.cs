using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    public float xSpace;
    public float xOffset;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("death");
        Destroy(gameObject, 1f);
        Destroy(collision.gameObject);
    }
    public float speed;
    private Vector2 direction;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (transform.position.x > 8f)
        {
            direction = Vector2.left;
        }

       if (transform.position.x < -8f)
        {
            direction = Vector2.right;
        }
    }
}
