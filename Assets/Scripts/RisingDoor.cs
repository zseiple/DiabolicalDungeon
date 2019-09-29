﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingDoor : MonoBehaviour
{
    public enum Direction { Front, Behind, Left, Right };
    public Direction triggerDirection = Direction.Front;
    public float triggerDistance;

    private Transform playerPos;
    private Vector3 triggerDirectionVector;
    private Vector3 goalPos;

    // Start is called before the first frame update
    void Start()
    {
        goalPos = transform.position;
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        switch (triggerDirection)
        {
            case Direction.Front:
                triggerDirectionVector = transform.forward;
                break;
            case Direction.Behind:
                triggerDirectionVector = -transform.forward;
                break;
            case Direction.Left:
                triggerDirectionVector = -transform.right;
                break;
            case Direction.Right:
                triggerDirectionVector = transform.right;
                break;
            default:
                triggerDirectionVector = transform.forward;
                break;
        }

        Vector3 startPos = transform.position;
        startPos.y -= GetComponent<Renderer>().bounds.size.y;

        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        //BOXCAST
    }
}