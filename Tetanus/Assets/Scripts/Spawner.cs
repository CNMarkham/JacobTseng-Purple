using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] tetanusDiseases;
    void Start()
    {
        SpawnTetanusDisease();
    }

    public void SpawnTetanusDisease()
    {
        Debug.Log(gameObject.name);
        int randNum = Random.Range(0, tetanusDiseases.Length);
        GameObject randomTetronmino = tetanusDiseases[randNum];
        Instantiate(randomTetronmino, transform.position, Quaternion.identity);
    }
}
