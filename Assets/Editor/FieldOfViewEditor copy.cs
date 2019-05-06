using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (FieldOfView))]
public class FieldOfViewEditor : Editor {
	void OnSceneGUI() {
        FieldOfView fow = (FieldOfView)target; 
        float rot = fow.rb.transform.rotation.z * 180;
        Handles.color = Color.white;
		Handles.DrawWireArc (fow.transform.position, Vector3.up, Vector3.forward, 360 , fow.viewRadius);
        Vector2 viewAngleA = fow.DirFromAngle((-fow.viewAngle / 2) + rot);
		Vector2 viewAngleB = fow.DirFromAngle((fow.viewAngle / 2) + rot);
        Vector2 lookDir = fow.DirFromAngle(rot);

		Handles.DrawLine (fow.transform.position, fow.transform.position + viewAngleA * fow.viewRadius);
		Handles.DrawLine (fow.transform.position, fow.transform.position + viewAngleB * fow.viewRadius);
        Handles.DrawLine (fow.transform.position, fow.transform.position + lookDir * fow.viewRadius);




        Handles.color = Color.red;

		foreach (Transform visibleTarget in fow.visibleTargets) {
			Handles.DrawLine (fow.transform.position, visibleTarget.position);
		}
	}

}
