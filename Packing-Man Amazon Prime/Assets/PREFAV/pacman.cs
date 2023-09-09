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
        }
    }



    
    // Update is called once per frame
    void Update()
    {
        if (nextDirection != Vector2.zero)
        {
            SetDirection(nextDirection);
        }
        transform.right = direction;
        ChildUpdate();
    }
}

