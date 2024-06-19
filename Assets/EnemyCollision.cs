using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField]
    string harmfullIfTouchedTag;
    [SerializeField]
    EnemyHealth healthScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        Debug.Log(go.gameObject);
        if (go.CompareTag("Finish"))
        {
            healthScript.GetDamage(1);
        }
    }
    
}
