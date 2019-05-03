using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeOpacity : MonoBehaviour {
    public float MaxOpacity;
    public float MinOpacity;

    public GameObject player;
    private Vector2 Dir;
    private float dist;
    private float distx;
    private float disty;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        distx = rb.position.x - transform.position.x;
        disty = rb.position.y - transform.position.y;
        dist = Mathf.Sqrt(Mathf.Pow(distx,2)+Mathf.Pow(disty,2));

        transform.renderer
    }
}
