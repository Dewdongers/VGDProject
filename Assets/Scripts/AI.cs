using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    GameObject Player;
    Vector2 Targ;

    void Start()
    {
        Player = GameObject.Find("Player");
        Targ = new Vector2(transform.position.x - Player.transform.position.x, transform.position.y - Player.transform.position.y);
    }

    void Update () {

        Targ.x = transform.position.x - Player.transform.position.x;
        Targ.y = transform.position.y - Player.transform.position.y;
        transform.rotation.Set(transform.rotation.x, transform.rotation.y, Mathf.Rad2Deg*Mathf.Tan(Targ.y/Targ.x),1);
	}
}
