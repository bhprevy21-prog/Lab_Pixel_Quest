using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatSide : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Vector3 targetPosition;

    void Start()
    {
        transform.position = pointA.position;
        targetPosition = pointB.position;
    }
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, pointA.position) < 0.1f)
        {
            targetPosition = pointB.position;
        }

        else if (Vector3.Distance(transform.position, pointB.position) < 0.1f)
        { targetPosition = pointA.position; }
    }
}
