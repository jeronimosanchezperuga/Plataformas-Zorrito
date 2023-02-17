using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;

    Vector3 velocity = Vector3.zero;

    void Start()
    {
        target = FindObjectOfType<CharacterController2D>().transform;
    }
    void FixedUpdate()
    {
        Vector3 movePosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position,movePosition, ref velocity, damping);
    }
}
