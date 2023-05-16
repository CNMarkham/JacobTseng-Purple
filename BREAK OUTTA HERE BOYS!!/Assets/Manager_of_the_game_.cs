using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager_of_the_game_ : MonoBehaviour
{
    public GameObject StupidRatPrefab;
    // Start is called before the first frame update
    public float xSpace;
    public float xOffset;
    void Start()
    {
        for (int x = 0; x < 10;x++)
        {
            Instantiate(StupidRatPrefab, new Vector2(x * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(StupidRatPrefab, new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(StupidRatPrefab, new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
