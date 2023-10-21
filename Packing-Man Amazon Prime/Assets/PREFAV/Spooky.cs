using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spooky : Movement
{
    public float homeDuration;
    public bool frightened;
    public GameObject body;
    public GameObject eyes;
    public GameObject blue;
    public GameObject white;
    protected override void ChildUpdate()
    {
        transform.position = new Vector3(0, 2.5f, -1f);
        direction = new Vector2(-1, 0);
        atHome = false;
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
        frightened = false;
    }

    private void LeaveHome()
    {

    }
    private void Awake()
    {
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
        frightened = false;
        Invoke("LeaveHome", homeDuration);
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
