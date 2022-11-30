using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCats : MonoBehaviour
{
    [SerializeField] GameObject catPrefab;
    [SerializeField] Transform[] spawnPosition;

    void Start()
    {
        InvokeRepeating("SpawnCat", 1.5f, 1.5f);
    }
    void SpawnCat()
    {
        GameObject cat = Instantiate(catPrefab);
        int randomNumber = Random.Range(0, spawnPosition.Length);
        cat.transform.position = spawnPosition[randomNumber].transform.position;
    }
}
