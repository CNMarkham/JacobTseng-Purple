using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEMENTED : MonoBehaviour
{

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

             collision.gameObject.GetComponent<PlayerBehaviour>().Hit();
            }
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