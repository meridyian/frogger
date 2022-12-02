using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    // on a fixed timer to choose a random laying and spawn a car

    [SerializeField] private float _spawnDelay = .3f;
   
    public GameObject car;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;
    public bool canspawn;

    //void Start(){
    //InvokeRepeating("SpawnCar", 0f, 3f);
    //}


    void Start()
    {
        canspawn = true;
        StartCoroutine(Spawner(_spawnDelay));
    }

    void SpawnCar()
    {
        // random spawn point from array


        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);

    }

    IEnumerator Spawner(float spawnDelay)
    {
        while (canspawn == true)
        {
            yield return new WaitForSeconds(spawnDelay);
            SpawnCar();
        }
    }



}
