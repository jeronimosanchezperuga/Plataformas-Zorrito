using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {

    }

    public void LooseALife()
    {
        int currentLives = GameManager.Instance.lives;
        currentLives--;
        if (currentLives == 0)
        {
            //GameOver
            GameManager.Instance.GameOver();
        }
        else
        {
            //Reset
            Destroy(gameObject);
            GameManager.Instance.lives = currentLives;
            GameManager.Instance.ReloadScene();
        }
    }
}
