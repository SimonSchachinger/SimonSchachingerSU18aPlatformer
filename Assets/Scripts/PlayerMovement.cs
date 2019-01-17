using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// hämta hem variabel typ RigidBody2D
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //gör att moveSpeed kan vara mellan 0 och 20
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;
    //kollar när spelaren nuddar marken
    public GroundCheck groundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        // rbody tilldelas Player's variabel värden
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // gör så att Player rör sig i sidled med hastighet moveSpeed
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
        // om man trycker på space och touches är högre än 0 (du nuddar marken)
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.touches > 0)
        {
            // så hoppar Player med höjden jumpHeight. hoppar man när Player rör sig i sidled fortsätter den
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }

    }
}
//funktion sammanfattningar
// OnTriggerExit2D: gör att något händer när två objekt slutar nudda varandra
// OnCollisionEnter2D: Gör att två objekt kolliderar och gör så att de stoppar varandra
// OntriggerEnter: Gör att något händer när två objekt kolliderar
