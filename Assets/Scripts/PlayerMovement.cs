using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public GameObject p;
    public Rigidbody2D rb;
    private Vector2 MoveVelocity;
    public int speed;
    private float angle;
    private Vector3 mp, op;

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
        mp = Input.mousePosition;
        mp.z = 5.23f; //The distance between the camera and object
        op = Camera.main.WorldToScreenPoint(rb.position);
        mp.x = mp.x - op.x;
        mp.y = mp.y - op.y;
        angle = Mathf.Atan2(mp.y, mp.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
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

