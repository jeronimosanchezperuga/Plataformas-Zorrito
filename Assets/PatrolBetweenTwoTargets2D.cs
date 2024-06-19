using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBetweenTwoTargets2D : MonoBehaviour
{
    public Transform patrollerTR;
    [SerializeField]
    Transform target1;
    [SerializeField]
    Transform target2;
    [SerializeField]
    float speed;
    Transform currentTarget;
    public bool toLeft = true;
    [SerializeField]
    private float distanceThreshold = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toLeft)
        {
            currentTarget = target1;
        }
        else
        {
            currentTarget = target2;
        }

        var step = speed * Time.deltaTime;
        patrollerTR.position = Vector3.MoveTowards(patrollerTR.position, currentTarget.position, step);

        if (Vector2.Distance(patrollerTR.position,currentTarget.position) < distanceThreshold)
        {
            toLeft = !toLeft;
            //flip the sprite to face the other side
            patrollerTR.Rotate(0,180,0);
        }
    }
}
