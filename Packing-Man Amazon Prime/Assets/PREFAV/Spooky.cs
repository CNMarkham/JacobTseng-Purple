using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spooky : Movement
{
    public bool atHome;
    public float homeDuration;
    public bool frightened;
    public GameObject body;
    public GameObject eyes;
    public GameObject blue;
    public GameObject white;
    protected override void ChildUpdate()
    {

    }

    public void Frighten()
    {
        if (!atHome)
        {
            frightened = true;
            body.SetActive(false);
            eyes.SetActive(false);
            blue.SetActive(true);
            white.SetActive(false);
            Invoke("Flash", 4f);
        }
    }

    private void Flash()
    {
        body.SetActive(false);
        eyes.SetActive(false);
        blue.SetActive(false);
        white.SetActive(true);
        Invoke("Reset", 4f);
    }

    private void Reset()
    {
        frightened = false;
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (atHome && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            SetDirection(-direction);
        }

        if (collision.gameObject.CompareTag("Pac"))
        {
            if (frightened)
            {
                transform.position = new Vector3(0, -0.5f, -1);
                body.SetActive(false);
                eyes.SetActive(true);
                blue.SetActive(false);
                white.SetActive(false);
                atHome = true;
                CancelInvoke();
                Invoke("LeaveHome", 4f);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
    private void LeaveHome()
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
