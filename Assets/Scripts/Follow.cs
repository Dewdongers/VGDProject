using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Rigidbody2D parent;
    public Rigidbody2D target;

	void Update () {
        parent.position = target.position;
    }
}
