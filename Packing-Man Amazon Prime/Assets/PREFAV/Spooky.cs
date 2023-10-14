using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spooky : Movement
{
  public GameObject body;
    protected override void ChildUpdate()
    {

    }

    private void Awake()
    {
        body.SetActive(true);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NODE node = collision.GetComponent<NODE>();
        if (node != null)
        {
            int index = Random.Range(0, node.availableDirections.Count);

            SetDirection(node.availableDirections[index]);

            if (node.availableDirections[index] == -direction)
            {
                index += 1;

                if (index == node.availableDirections.Count)
                {
                    index = 0;
                }
            }
            SetDirection(node.availableDirections[index]);
        }



}
}
