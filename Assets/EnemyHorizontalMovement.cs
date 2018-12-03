using System.Collections;
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
        //print("Hjälp");
        if (flip == true)
        {
            //avgör vilket håll fienden går åt
            isLeft = !isLeft;
        }
        //om isLeft är sann rör sig fienden åt höger
        if (isLeft == true)
        {// gör så att fienden kan röra sig åt höger
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {//om isLeft inte är sann rör sig fienden åt vänster
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {// gör så att fiendens sprite flippas när den nuddar en osynlig vägg
        if (collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
