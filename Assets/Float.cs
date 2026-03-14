using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public Transform pointA;
        public Transform pointB;
    public float speed = 2f;

    private Vector2 targetPosition;

    void Start()
    {
        transform.position = pointA.position;
        targetPosition = pointB.position;
    }
    void Update()
    {
       
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, pointA.position) < 0.1f)
        {
            targetPosition = pointB.position;
        }

        else if (Vector2.Distance(transform.position,pointB.position) <0.1f)
        {  targetPosition = pointA.position; }
    }
}
