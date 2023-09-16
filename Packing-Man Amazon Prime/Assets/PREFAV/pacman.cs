using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacman : Movement
{
    protected override void ChildUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || Vertical != 0)
        {
            SetDirection(new Vector2(horizontal, Vertical));

            transform.right = direction;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        base.Start();
    }


    // Update is called once per frame
    void Update()
    {
        base.Update();
    }
}

