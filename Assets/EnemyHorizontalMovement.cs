﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float moveSpeed = 2f;

    public bool isLeft = true;

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Move(true);
        }
    }
    void Move(bool flip)
    {
        if (flip == true)
        {
            isLeft = !isLeft;
        }

        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}