using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3;  //how ,amy click until the balloon pops
    public float scaleToIncrease = 0.10f;  //how much the baloon inflates per click % based scaling

    {
        clickToPop -= 1; // Reduce clicks by 1

        //inflate baloon a certaint amount every time it is clicked on
        transform.localScale += Vector3.one * scaleToIncrease;

        //check to see if clickToPop has reached zero. If it has 0 then pop balloon
        if(clickToPop == 0)
        {
            Destroy(gameObject);
        }
        if(clickToPop == 1)
        {
            Destroy(gameObject);
        }
        if(clickToPop == 2)
        {
            Destroy(gameObject);
        }
        if(clickToPop == 3)
        {
            Destroy(gameObject);
        }
        if(clickToPop == 4)
        {
            Destroy(gameObject);
        }
        //I don't know other commands busides destroy, there has to be a rotate and move i don't know how they work yet
    }
}