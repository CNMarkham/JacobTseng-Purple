using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    private Animator animator;
    public float speed;
    static private Vector2 direction;

   

    void Start()
    {
        animator = GetComponent<Animator>();
        direction = Vector2.right;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("death");
        Destroy(gameObject, 1f);
        Destroy(collision.gameObject);
    }
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (transform.position.x > 10f)
        {
            direction = Vector2.left; 
            MoveDown();
        }

       if (transform.position.x < -10f)
        {
            direction = Vector2.right;
            MoveDown();
        }
    }
    private void MoveDown()
    {
        foreach (ENEMY enemy in FindObjectsOfType(typeof(ENEMY)))
        {
           enemy.transform.Translate(Vector2.down);
        }
    }
}