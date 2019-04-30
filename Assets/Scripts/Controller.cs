using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float moveSpeed = 6;

    Rigidbody2D rigidbody;
    Camera viewCamera;
	Vector2 velocity;
    private float angle;
    private Vector3 mp, op;

    void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		viewCamera = Camera.main;
	}

	void Update () {
		Vector2 mousePos = viewCamera.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		transform.LookAt (mousePos + Vector2.up * transform.position.y);
		velocity = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")).normalized * moveSpeed;
        Aim();

	}

	void FixedUpdate() {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.deltaTime);
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