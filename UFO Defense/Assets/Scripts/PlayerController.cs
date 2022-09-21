using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float speed;

    public float xRange = 11.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizntal input to recive values from the keyboard keymap horizntal
        hInput = Input.GetAxis("Horizontal");

        //Move the player left and right
        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);

        //keep player within set bounds
        //keep player inside right wall at set xRange
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //keep player inside right wall at set xRange
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
