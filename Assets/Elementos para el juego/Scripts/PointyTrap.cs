using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointyTrap : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] GameObject fxFeedback;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            AffectPlayer(collision.gameObject);
            PickedUpBehavior();
        }
    }

    void PickedUpBehavior()
    {
        Instantiate(fxFeedback, gameObject.transform.position, Quaternion.identity);
    }

    void AffectPlayer(GameObject playerGO)
    {
        playerGO.GetComponent<PlayerBlink>().Blink();
        playerGO.GetComponent<KnockBack>().ActivateKnockBack(transform);
    }
}