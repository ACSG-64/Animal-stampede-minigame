using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float xSpawnRange = 20f;
    public float zSpawnPos = 20f;
    public float startDelaySecs = 2f;
    public float spawnIntervalSecs = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelaySecs, spawnIntervalSecs);
    }

    // Update is called once per frame
    void Update()
    {       
    }

    private void SpawnRandomAnimal()
    {
        int animalIdx = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPos);
        Instantiate(animalPrefabs[animalIdx], spawnPosition, animalPrefabs[animalIdx].transform.rotation);
    }
}
