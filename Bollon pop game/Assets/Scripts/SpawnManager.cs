using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Global variables
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    public float xRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalloon()
    {
        // Get a random point on x-axis
        Vector3 spawnPosX = new Vector3(Random.Range(-xRange,xRange),0,0);

        //PIck a random balloon from the balloon array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);

        // Spawn a random balloon
        Instantiate(balloonPrefabs[balloonIndex], spawnPosX, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
