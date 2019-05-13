using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
	
	void Update () 
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}


    void Shoot()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            Debug.Log("Yeetle in the behindeedle");
        }
    }
}
