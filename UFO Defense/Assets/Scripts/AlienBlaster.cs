using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBlaster : MonoBehaviour
{
    public GameObject LaserBolt;
    public Transform alienBlaster;

    public float startDelay = 3;
    public float spawnInterval = 1.5;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AlienShoot", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AlienShoot()
    {
        Instantiate(LasterBolt, alienBlaster, LaserBolt.transform.rotation);
    }
}
