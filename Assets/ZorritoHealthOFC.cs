using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZorritoHealthOFC : MonoBehaviour
{
    public int healthPoints;
    public int livesCount;
    public int maxHealthPoints;

    // Start is called before the first frame update
    void Start()
    {
        livesCount = 3;
        healthPoints = maxHealthPoints;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            TakeDamage(5);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            TakeCure(5);
        }
    }

    public void TakeDamage(int damagePoints)
    {
        healthPoints -= damagePoints;
        if (healthPoints <= 0)
        {
            LooseALife();
        }
    }

    public void TakeCure(int curePoints)
    {
        healthPoints += curePoints;
    }

    void LooseALife()
    {
        livesCount--;
        if (livesCount <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            healthPoints = maxHealthPoints;
        }
    }
}
