using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubioController : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] CharacterController2D controller;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        controller = GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.m_Grounded)
        {
            anim.SetFloat("velocity",rb.velocity.magnitude);
            if (Input.GetButtonDown("Fire1"))
            {
                anim.SetTrigger("attack");
            }
        }
        else
        {
            anim.SetFloat("velocity", 0f);
        }

        if (Input.GetButtonDown("RubioFire1"))
        {
            anim.SetTrigger("attack");
        }
    }
}
