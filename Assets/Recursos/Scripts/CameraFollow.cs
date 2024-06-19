using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.position = new Vector3(Mathf.Clamp(target.position.x, leftLimit, rightLimit), transform.position.y, transform.position.z);
        }
            

        
    }
}
