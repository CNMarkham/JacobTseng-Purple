using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_of_the_game_ : MonoBehaviour
{
    public GameObject StupidRatPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 10;x++)
        {
            Instantiate(StupidRatPrefab, new Vector2(x, 3), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
