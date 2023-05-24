using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    public float xSpace;
    public float xOffset;
    void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            Instantiate(Enemy,new Vector2(xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(Enemy,new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(Enemy,new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    } 
}
