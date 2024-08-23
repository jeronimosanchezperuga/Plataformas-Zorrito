﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]private float knockBackDuration;
    [SerializeField]private float knockBackForce;
    [SerializeField]private Transform obj;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ActivateKnockBack(Transform obj)
    {
        StartCoroutine(IKnockBack(knockBackDuration, knockBackForce, obj));
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
