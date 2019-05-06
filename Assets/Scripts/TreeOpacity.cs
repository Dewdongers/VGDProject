using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeOpacity : MonoBehaviour
{
    public float MaxOpacity;
    public float MinOpacity;

    public GameObject tree;
    private Renderer rend;
    private GameObject player;
    private Vector2 Dir;
    private float dist;
    private float distx;
    private float disty;
    private Rigidbody2D rb;

    private void Start()
    {
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody2D>();
        rend = tree.GetComponent<Renderer>();

    }

    private void Update()
    {
        distx = rb.position.x - tree.GetComponent<Rigidbody2D>().position.x;
        disty = rb.position.y - tree.GetComponent<Rigidbody2D>().position.y;
        dist = Mathf.Sqrt(Mathf.Pow(distx,2)+Mathf.Pow(disty,2));
        rend.material.color = new Color(1.0f, 1.0f, 1.0f, dist);
    }
}
