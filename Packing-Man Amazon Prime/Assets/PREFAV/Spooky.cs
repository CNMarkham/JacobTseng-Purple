using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spooky : Movement
{
    protected override void ChildUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NODE Node = collision.GetComponent<NODE>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
