using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlast : MonoBehaviour
{

    public float speed =30f;
    public int damage = 10;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    // detect any collisions and triggers
    void OnTriggerEnter2D(Collider2D other)
    {
        PumpkinEnemy enemy = other.GetComponent<PumpkinEnemy>();

        if(other.gameObject.CompareTag("Enemy"))
        {
            enemy.TakeDamage(damage); //run take damge function and apply damgae to enemy
        }

        Destroy(gameObject); //Destroy projectile

    }

}
