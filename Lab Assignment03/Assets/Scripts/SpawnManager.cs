using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    // public int animalIndex;
    
    private float spawnRangex = 13;
    private float spawnPosz = 4;

    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating( "SpawnRandomAnimal", startDelay, spawnInterval);
    }
    
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.S))
        // {
        // SpawnRandomAnimal();    
        // }

        // void SpawnRandomAnimal()
        // {
        //     Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex),0, spawnPosz);

        //     int animalIndex = Random.Range(0,animalPrefabs.Length);
        //     Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        // }
    }
        void SpawnRandomAnimal()
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex),0, spawnPosz);

            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
}
