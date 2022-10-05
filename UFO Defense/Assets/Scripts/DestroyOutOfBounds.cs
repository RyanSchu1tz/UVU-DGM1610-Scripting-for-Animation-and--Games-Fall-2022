using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;

    private ScoreManager scoreManager;
    private DetectColision detectColision;


    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectColision = GetComponent<DetectColision>();
    }

    // Update is called once per frameasdaasaadaf
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBounds)
        {
            scoreManager.DecreaseScore(detectColision.scoreToGive); // every time a ship go past reduce points
            Destroy(gameObject);
        }
    }
}
