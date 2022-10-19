using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float speed;

    public float xRange = 21.5f;

    public GameObject lazerBolt; //game obeject projectile to shoot
    public Transform blaster;  //Point of origin for the lazerBolt

    private AudioSource blasterAudio;
    public AudioClip laserBlast;


    // Start is called before the first frame update
    void Start()
    {
        blasterAudio = GetComponent<AudioSource>();
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            blasterAudio.PlayOneShot(laserBlast,0.5f);
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);  //instatntiate lazerbolt gameobject at blaster position
        }
    }
}
