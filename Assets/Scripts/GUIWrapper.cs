using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIWrapper : MonoBehaviour {
    public GameObject player;
    public float x;
    public float y;
    public float w;
    public float h;
    public string Label;
    public string value; 
    float val;

    public void Update()
    {
        val = player.GetComponent<Rigidbody2D>().transform.rotation.z;
    }
    public void OnGUI()
    {
        GUI.Label(new Rect(x, y, w, h), Label + val);
    }
}
