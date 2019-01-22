using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    float speed = 2;
    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

	void Update ()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed,Space.Self);
	}
}
