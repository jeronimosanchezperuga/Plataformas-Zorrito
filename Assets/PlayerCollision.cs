using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    string harmfullIfTouchedTag;
    [SerializeField]
    Health healthScript;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject go = collision.gameObject;
        if (go.CompareTag(harmfullIfTouchedTag))
        {
            //gets the statistics of the character touched
            CharacterStats charStats = go.GetComponent<CharacterStats>();
            //if the component exists, use its data
            if (charStats)
            {
                healthScript.GetDamage(charStats.damagePoints, collision.gameObject.transform);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            healthScript.LooseALife();
        }else if (collision.gameObject.CompareTag("Bullet"))
        {
            healthScript.GetDamage(1, collision.gameObject.transform);
            Destroy(collision.gameObject);
        }
    }
}
