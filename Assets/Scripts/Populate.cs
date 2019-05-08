using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Populate : MonoBehaviour {

    private readonly System.Random rng = new System.Random();

    public GameObject[] objs;

    public int Density;
    public float sizeMin;
    public float sizeMax;

    public float xMin;
    public float yMin;
    public float xMax;
    public float yMax;

    void Start()
    {
        for (int j = 0; j < objs.Length; j++)
        {
            for (int i = 0; i < 20 * Density; i++)
            {
                Vector3 trans = new Vector3(rng.Next((int)xMin, (int)xMax), rng.Next((int)yMin, (int)yMax), 0);
                Quaternion rot = new Quaternion(0, 0, rng.Next(0, 360), 180);
                GameObject temp = Instantiate(objs[j], trans, rot);
                float z = (float)(rng.NextDouble() * (sizeMax - sizeMin) + sizeMin);
                temp.transform.parent = transform;
                temp.transform.localScale = new Vector3(z, z, z);

            }
        }

    }


}
