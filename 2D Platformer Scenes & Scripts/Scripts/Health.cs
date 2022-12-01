using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public int deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
    }
        public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Player Health = "+ currentHealth);

        if(currentHealth <=0)
        {
            Debug.Log("You are dead! Game Over!"); //Game Over Message
            Time.timeScale = 0; //Freeze the game
        }
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)//puts a cap on current health amount
        {
            currentHealth = maxHealth;
        }
    }
}
    