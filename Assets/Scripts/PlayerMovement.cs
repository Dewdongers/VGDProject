using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public GameObject p;
    public Rigidbody2D rb;
    private Vector2 MoveVelocity;
    public int speed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        Aim();
        Move();
    }

    void Aim()
    {

    }
    void Move()
    {
        Vector2 mvinp = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        MoveVelocity = mvinp.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveVelocity * Time.fixedDeltaTime);
    }
}

