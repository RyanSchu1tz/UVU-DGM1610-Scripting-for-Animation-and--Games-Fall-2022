using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinEnemy : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if(health <= 0)//Check to see if the remaning enemie health is reduced to zero
        {
            Death();// run death method
        }
    }

    void Death()
    {
        // add sound and particicle effects
        Destroy(gameObject); //destroy enemy
    }
}
