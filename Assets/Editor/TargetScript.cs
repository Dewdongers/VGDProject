using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AI))]
public class TargetScript : Editor
{
    GameObject[] allObjects;
    void OnSceneGUI()
    {
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
            if (go.tag.Equals("Zombie"))
            {
                Vector3 ang = go.transform.position;
                ang.x += (Mathf.Cos(go.transform.rotation.z * Mathf.Deg2Rad) * Mathf.Rad2Deg);
                ang.y += (Mathf.Sin(go.transform.rotation.z * Mathf.Deg2Rad) * Mathf.Rad2Deg);
                Handles.DrawLine(go.transform.position, ang);
            }
    }
}