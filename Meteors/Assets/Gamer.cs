using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer : MonoBehaviour
{
    public GameObject rockPrefab;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRocks", 0f, 10f);
    }
    void Update()
    {

    }
    private void SpawnRocks()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 randomPosition = spawnPoints[Random.Range(0, 3)].position;
            Instantiate(rockPrefab, randomPosition, Quaternion.identity);
        }
    }
}
