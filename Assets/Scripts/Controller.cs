using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    public float moveSpeed = 6;
    private float angle;
    new Rigidbody rigidbody;
    Camera viewCamera;
    Vector3 velocity;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        viewCamera = Camera.main;
    }

    void Update()
    {
        //Aim();
        //Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //transform.LookAt(mousePos + Vector3.up * transform.position.y);
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
        velocity = rigidbody.transform.TransformDirection(velocity);

    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
    }

    //void Aim()
    //{
    //    angle = Mathf.Atan2(Input.mousePosition.y - Camera.main.WorldToScreenPoint(rigidbody.position).y, Input.mousePosition.x - Camera.main.WorldToScreenPoint(rigidbody.position).x) * Mathf.Rad2Deg - 90;
    //    transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    //}
}