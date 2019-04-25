using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public GameObject p;
    public int speed;
    private Vector3 move = new Vector3(0,0,0);

    // Use this for initialization
    void Start () {	
	}


	
	// Update is called once per frame
	void Update () {
        Aim();
        Move();
	}

    void Aim() {
        Vector3 aimDir = Input.mousePosition;
        p.transform.eulerAngles = new Vector3(0 , 0, (Mathf.Atan(aimDir.y / aimDir.x)/Mathf.PI)*180);
    }
    void Move()
    {

        if(Input.GetKeyDown("a")) {
            move.x -= speed;
        }

        if (Input.GetKeyDown("d"))
        {
            move.x += speed;
        }


        if (Input.GetKeyDown("w"))
        {
            move.y += speed;
        }

        if (Input.GetKeyDown("s"))
        {
            move.y -= speed;
        }
        p.transform.localPosition = move;
    }
}

