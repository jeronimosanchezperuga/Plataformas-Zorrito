using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AutoDestruction(float t)
    {
        Destroy(gameObject,t);
    }
}
