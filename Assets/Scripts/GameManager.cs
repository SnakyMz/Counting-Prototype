using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> fruits;
    [SerializeField] float spawnRange = 8;
    [SerializeField] float spawnTop = 14;
    [SerializeField] float startDelay = 2;
    [SerializeField] float spawnDelay = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnFruit", startDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFruit()
    {
        Vector3 spawnPos = new Vector3(0, spawnTop, Random.Range(-spawnRange, spawnRange));
        int index = Random.Range(0, fruits.Count);
        Instantiate(fruits[index], spawnPos, fruits[index].transform.rotation);
    }
}
