using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject sword;
    [SerializeField] GameObject shield;
    [SerializeField] Transform shieldRef;
    
    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                SwordAttack();
            if (shield)
            {
               var clon = Instantiate(shield, shieldRef.position, Quaternion.identity);
                Vector3 newScale = Vector3.one * transform.localScale.x; ;
                clon.transform.localScale = newScale;
                Destroy(clon,.2f);
            }
        }        
    }

    void SwordAttack()
    {
        Invoke("EnableSword", 0);
        Invoke("DisableSword", 0.2f);
    }

    void EnableSword()
    {
        sword.SetActive(true);
    }
    void DisableSword()
    {
        sword.SetActive(false);
    }
}
