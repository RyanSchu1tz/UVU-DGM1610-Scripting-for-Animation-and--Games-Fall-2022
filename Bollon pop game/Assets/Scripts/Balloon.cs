using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3;  //how ,amy click until the balloon pops
    public float scaleToIncrease = 0.10f;  //how much the baloon inflates per click % based scaling
    public int scoreToGive = 100;
    private ScoreManager scoreManager;



    // Start is called before the first frame updatepublic int click to update
    void Start()
    {
             //Refrance ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); 
    }


    void OnMouseDown()
    {
        clickToPop -= 1; // Reduce clicks by 1

        //
        transform.localScale += Vector3.one * scaleToIncrease;

        //
        if(clickToPop == 0)
        {
            // Send points to score manager and update the score
            scoreManager.IncreaseScoreText(scoreToGive);
            // Destroy this balloon
            Destroy(gameObject);
        }
        
    }
}
