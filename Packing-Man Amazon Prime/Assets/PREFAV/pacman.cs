using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class pacman : Movement
{
    //protected override void ChildUpdate()
    //{
    //    float horizontal = Input.GetAxisRaw("Horizontal");
    //    float vertical = Input.GetAxisRaw("vertical");
    //}

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (nextDirection != Vector2.zero)
        {
            SetDirection(nextDirection);
        }

        //ChildUpdate();
    }
}

