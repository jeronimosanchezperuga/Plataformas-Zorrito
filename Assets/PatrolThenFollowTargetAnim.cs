using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolThenFollowTargetAnim : MonoBehaviour
{
    public Transform patrollerTR;
    [SerializeField]
    Transform target1;
    [SerializeField]
    Transform target2;
    [SerializeField] Transform targetPplayer;
    [SerializeField] float speed;
    [SerializeField] float normalspeed;
    [SerializeField] float chaseSpeed;
    Transform currentTarget;
    public bool toLeft = true;
    [SerializeField] private float distanceThreshold = 1f;
    [SerializeField] float chaseDistance = 1f;
    public float direction;
    [SerializeField] float distanceToPlayer;
    // Start is called before the first frame update
    void Start()
    {
        targetPplayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (!target1)
        {
            target1 = targetPplayer;
        }
        currentTarget = target1;

    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector2.Distance(patrollerTR.position, targetPplayer.position);
        if ( distanceToPlayer < chaseDistance)
        {
            currentTarget = targetPplayer;
            speed = chaseSpeed;            
        }
        else
        {
            speed = normalspeed;
            if (toLeft)
            {
                currentTarget = target1;
            }
            else
            {
                currentTarget = target2;
            }

            if (Vector2.Distance(patrollerTR.position, currentTarget.position) < distanceThreshold)
            {
                toLeft = !toLeft;
                //flip the sprite to face the other side
                //patrollerTR.Rotate(0, 180, 0);
            }
        }

        var step = speed * Time.deltaTime;
        patrollerTR.position = Vector3.MoveTowards(patrollerTR.position, currentTarget.position, step);

        float spriteRotation = currentTarget.transform.position.x < patrollerTR.position.x ? 180 : 0;
        patrollerTR.eulerAngles = new Vector2(0, spriteRotation);


    }
}
