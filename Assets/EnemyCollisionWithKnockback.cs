using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionWithKnockback : MonoBehaviour
{
    [SerializeField]
    string harmfullIfTouchedTag;
    [SerializeField]
    EnemyHealth healthScript;
    [SerializeField] FollowAndSwitchTargets followScript;
    [SerializeField] Transform parentTR;
    [SerializeField] float knockForce;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        followScript = GetComponentInParent<FollowAndSwitchTargets>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        if (go.CompareTag("Finish"))
        {
            healthScript.GetDamage(1);

            
            parentTR.Translate(Vector2.left * knockForce);

        }
    }
    
}
