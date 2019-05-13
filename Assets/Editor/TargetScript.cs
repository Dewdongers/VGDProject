using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (AI))]
public class TargetScript : Editor
{
    GameObject[] allObjects;
    void OnScreenGUI()
    {
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        Debug.Log(allObjects.Length);
        foreach (GameObject go in allObjects)
            if (go.tag.Equals("Zombie"))
            {
                Vector3 ang = new Vector3(go.transform.position.x * Mathf.Cos(go.transform.rotation.z) * Mathf.Rad2Deg, go.transform.position.y * Mathf.Sin(go.transform.rotation.z) * Mathf.Rad2Deg, 1);
                Handles.DrawLine(go.transform.position, ang);
            }
    }
}