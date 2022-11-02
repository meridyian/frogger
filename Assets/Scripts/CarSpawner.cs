using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    // on a fixed timer to choose a random laying and spawn a car

    public float spawnDelay = .3f;

    public GameObject car;

    float nextTimeToSpawn = 0f;

    float countDownTimer = 3f;


    void Update()
    {
        // from amount of seconds elapsed to nexttimespawn

        if(nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        Instantiate(car);
    }




}
