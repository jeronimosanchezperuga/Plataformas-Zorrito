using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackUSS : MonoBehaviour
{
    [SerializeField] GameObject sword;
    [SerializeField] Transform swordRef;
    [SerializeField] Vector3 swordDistance;
    [SerializeField] float attackAreaSize = 1f;
    
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
        }
    }

    void SwordAttack()
    {
        //store orientation when attacking
        Invoke("EnableSword", 0);
        Invoke("DisableSword", 0.2f);
    }

    void EnableSword()
    {

        sword.SetActive(true);
        Vector3 oldScale = sword.transform.localScale;
        Vector3 newScale = new Vector3( Mathf.Abs(oldScale.x) * transform.localScale.x,oldScale.y,oldScale.z) ;
        sword.transform.localScale = newScale;
        //Vector3 newDistance = new Vector2(Mathf.Abs(swordDistance.x) * attackAreaSize * transform.localScale.x, swordDistance.y);
        //sword.transform.position = swordRef.transform.position + newDistance ;
    }

    void DisableSword()
    {
        sword.SetActive(false);
    }
}
