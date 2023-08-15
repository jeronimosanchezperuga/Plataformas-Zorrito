using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target;
    public Transform limitBottomLeft;
    public Vector3 offset;
    public float damping;

    Vector3 velocity = Vector3.zero;

    void Start()
    {
        target = FindObjectOfType<CharacterController2D>().transform;
    }
    void FixedUpdate()
    {
        float minX = Mathf.Clamp(target.position.x, limitBottomLeft.position.x, Mathf.Infinity) ;
        float minY = Mathf.Clamp(target.position.y, limitBottomLeft.position.y, Mathf.Infinity) ;
        Vector3 movePosition = new Vector3(minX, minY,0) + offset;
        transform.position = Vector3.SmoothDamp(transform.position,movePosition, ref velocity, damping);
    }
}
