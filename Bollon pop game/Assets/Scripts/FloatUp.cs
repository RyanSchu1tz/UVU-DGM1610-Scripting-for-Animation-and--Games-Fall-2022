using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{  

    public float moveSpeed;   // Speed at which the balloon will move upwards
    public float upperBound;  // Top boundry for when the balloon exits the screen it will get destroyed

    private Balloon balloon;  // Referance the balloon gameobject

    // Start is called before the first frame update
    void Start()
    {
      balloon = GetComponent<Balloon>();  
    }

    // Update is called once per frame
    void Update()
    {
        // move the balloon upwards
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        //destroy ballon if it passes the top threshold
        if(transform.position.y > upperBound)
        {
            Destroy(gameObject);
        }
    }
}
