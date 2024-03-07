using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] tetanusDiseases;   
    void Start()
    {

    }

    public void SpawnTetanusDisease()
    {
        int randNum = Random.Range(0, tetanusDiseases.Length);
        GameObject randomTetronmino = tetanusDiseases[randNum];
        Instantiate(randomTetronmino, transform.position, Quaternion.identity);
    }
}
