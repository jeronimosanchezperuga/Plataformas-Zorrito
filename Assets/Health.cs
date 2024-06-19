using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int lives = 3;
    public int health = 3;
    [SerializeField]
    private GameObject blink;
    [SerializeField] Rigidbody2D rb;
    public float knockBackForce;
    public float knockBackDuration;
    [SerializeField]
    private float noDamageTime = 1f;
    [SerializeField]private Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        blink.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(int damageAmount,Transform obj)
    {
        health -= damageAmount;
        //damage animation + sound + etc
        Blink();
        StartCoroutine(IKnockBack(knockBackDuration,knockBackForce,obj));
        Invulnerability();
        if (health <= 0)
        {
            LooseALife();
            return;
        }
        //update UI
    }

    void Death()
    {
        Destroy(gameObject);
    }

    public void LooseALife()
    {
        lives--;
        if (lives <= 0)
        {
            //die
            Invoke("Death", 0.1f);
            return;
        }
        transform.position = spawnPoint;
    }
    void Invulnerability()
    {
        Invoke("SendToSafeLayer",0);
        Invoke("SendToDefaultLayer", noDamageTime);
    }

    void SendToSafeLayer()
    {
        gameObject.layer = 9;
    }

    void SendToDefaultLayer()
    {
        gameObject.layer = 0;
    }

    void Blink()
    {
        Invoke("EnableBlink", 0);
        Invoke("DisableBlink", 0.1f);
    }

    void EnableBlink()
    {
        blink.SetActive(true);
    }
    void DisableBlink()
    {
        blink.SetActive(false);
    }

    IEnumerator IKnockBack(float duration, float power, Transform obj)
    {
        float timer = 0;
        while (duration > timer)
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - transform.position).normalized;
            rb.velocity = Vector2.zero;
            rb.AddForce(-direction * power);
        }
        yield return 0;
    }
}
