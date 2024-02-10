using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kooper : MonoBehaviour
{
    private bool shelled;
    private bool shellmoving;
    public float shellSpeed = 15;
    // Start is called before the first frame update
    void Start()
    {
        shelled = false;
        shellmoving = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        if (collision.transform.position.y > transform.position.y + 0.4f)
        {
            Rigidbody2D playerRB = collision.gameObject.GetComponent<Rigidbody2D>();
            playerRB.velocity = new Vector2(playerRB.velocity.x, 10);
            if (shelled)
            {
                Launch();
            }
            else
            {
                GetComponent<Animator>().SetTrigger("shell");
                GetComponent<EnemyMove>().speed = 0;
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                shelled = true;
            }
        }
        else if (shelled && !shellmoving)
        {
            Launch();
        }
        else
        {
            collision.gameObject.GetComponent<PlayerBehaviour>().Hit();
        }
    }

    private void Launch()
    {
        GetComponent<EnemyMove>().speed = 15;
        GetComponent<Rigidbody2D>().velocity = Vector3.right * 15;
        shellmoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
