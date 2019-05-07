using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trunk : MonoBehaviour {

    public GameObject tree;
    public GameObject trunk;
    public int treeSize;

    void Start () {
        if (tree.transform.localScale.x > treeSize)
        {
            GameObject t = Instantiate(trunk);
            t.transform.localScale = tree.transform.localScale;
            t.transform.position = tree.transform.position;
            t.transform.parent = transform;
        }
    }
}
