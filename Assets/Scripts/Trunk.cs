using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trunk : MonoBehaviour {

    public GameObject tree;
    public GameObject trunk;

    void Start () {
        trunk.transform.localScale = tree.transform.localScale;
	}
}
