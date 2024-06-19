using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimToTarget : MonoBehaviour
{
    public Transform target;
    public float yOffset = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Aim2D(target);
    }


    void Aim(Transform target)
    {
        transform.LookAt(target.position);
    }
    void Aim2D(Transform target)
    {
        transform.right = (target.position + Vector3.up * yOffset) - transform.position;
    }

    
}
