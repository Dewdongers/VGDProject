using UnityEngine;
using System.Collections.Generic;

public class FieldOfView : MonoBehaviour
{
    public int viewRadius;
    [Range(0, 360)]
    public int viewAngle;

    public int castResolution;

    public GameObject player;
    private GameObject[] targets;
    private Ray2D[] viewRays;

    public void Start()
    {
        viewRays = new Ray2D[castResolution * 360];
    }

    public void Update()
    {
        for (int i = 0; i < castResolution * 360; i++)
        {
            viewRays[i] = Ray2D();
        }
    }
}
