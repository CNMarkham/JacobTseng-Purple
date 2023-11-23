using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOLLOW : MonoBehaviour
{
    public GameObject Target;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Target.transform.position - transform.position;
        transform.Translate(direction * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, 1);
    }
}
