using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float moveSpeed = 6;

	Rigidbody rigidbody;
	Camera viewCamera;
	Vector2 velocity;

	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		viewCamera = Camera.main;
	}

	void Update () {
		Vector2 mousePos = viewCamera.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		transform.LookAt (mousePos + Vector2.up * transform.position.y);
		velocity = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")).normalized * moveSpeed;
	}

	void FixedUpdate() {
        rigidbody.MovePosition(rigidbody.position+velocity* Time.deltaTime);
	}
}