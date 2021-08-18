using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    int startingHealth = 5;
    int currentHealth;
    int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }
    public void Damage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            if (gameObject.name == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                this.gameObject.SetActive(false);
                enemyCount++;
                if (enemyCount > 3)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
