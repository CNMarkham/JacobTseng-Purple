using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetanusDisease : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right);
        }
    }

    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);
        }
        if (x < 0 || y < 0)
        {

        }
    }
}
