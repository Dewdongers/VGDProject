using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGen : MonoBehaviour {
    private readonly System.Random rng = new System.Random();
    public GameObject tree;
    public int Density;
    public float x1;
    public float y1;
    public float x2;
    public float y2;

	void Start () {
        for (int i = 0; i < 20 * Density; i++)
        {
            Vector3 trans = new Vector3(rng.Next((int)x1, (int)x2),rng.Next((int)y1, (int)y2),0);
            Quaternion rot = new Quaternion(0, 0, rng.Next(0, 360), 180);
            GameObject temp = Instantiate(tree,trans,rot);
            float j = (float)(rng.NextDouble() * 16);
            temp.transform.localScale = new Vector3(j,j,j);

        }
	}
}
