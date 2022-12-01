using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        //particlals or animation
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy has parished!");
        }   

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        TakeDamage(1);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(damage + "Damage Taken");
    }
}
