using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetanusDisease : MonoBehaviour
{
    public Vector3 rotationPoint;
    private float previousTime;
    public float fallTime = 0.8f;
    public static int width = 10;
    public static int height = 20;
    public float speed;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Vector3 convertedPoint = transform.TransformPoint(rotationPoint);
            transform.RotateAround(convertedPoint, Vector3.forward, 90);
            if (!ValidMove())
            {
                transform.RotateAround(convertedPoint, Vector3.forward, -90);
            }
        }
    


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left, Space.World);
            if (!ValidMove())
            {
                transform.Translate(Vector2.right, Space.World);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right, Space.World);
            if (!ValidMove())
            {
                transform.Translate(Vector2.left, Space.World);
            }
        }

        float tempTime = fallTime;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            tempTime = tempTime / 10;
        }

        if (Time.time - previousTime > tempTime)
        {
            previousTime = Time.time;
            transform.Translate(Vector3.down, Space.World);
            if (!ValidMove())
            {
                transform.Translate(Vector2.up, Space.World);
                this.enabled = false;
                FindObjectOfType<Spawner>().SpawnTetanusDisease();
            }
        }
    }

    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);
            if (x < 0 || y < 0)
            {
                return false;
            }

            if(x >= width || y >= height)
            {
                return false;
            }
        }
        return true;

    }
}
