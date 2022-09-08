using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3;  //how ,amy click until the balloon pops
    public float scaleToIncrease = 0.10f;  //how much the baloon inflates per click % based scaling



    // Start is called before the first frame updatepublic int click to update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; // Reduce clicks by 1

        //inflate baloon a certaint amount every time it is clicked on
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            Destroy(gameObject);
        }
        
    }
}
