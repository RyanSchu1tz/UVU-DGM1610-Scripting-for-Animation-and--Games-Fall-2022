using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColision : MonoBehaviour
{

    private ScoreManager scoreManager; // A variable to hole the referacne to the scoremanager
    public int scoreToGive;
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        explosionParticle.Play();
        scoreManager.IncreaseScore(scoreToGive); // increase score
        Destroy(other.gameObject); //Destroy the other game object it hits
        Destroy(gameObject); //destroy this game object    
    }
}
