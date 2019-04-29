using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    public float moveSpeed = 6;
    private float angle;


    Rigidbody rigidbody;
    Camera viewCamera;
    Vector3 velocity;
    private Vector3 mp, op;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        viewCamera = Camera.main;
    }

    void Update()
    {
        Aim();
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        transform.LookAt(mousePos + Vector3.up * transform.position.y);
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
    }

    void Aim()
    {
        mp = Input.mousePosition;
        mp.z = 5.23f; //The distance between the camera and object
        op = Camera.main.WorldToScreenPoint(rigidbody.position);
        mp.x = mp.x - op.x;
        mp.y = mp.y - op.y;
        angle = Mathf.Atan2(mp.y, mp.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}