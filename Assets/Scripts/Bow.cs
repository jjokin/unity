using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {

    public Transform muzzle;
    public Projectile projectile;
    public float msBetweenShots = 1000;
    public float muzzleVelocity = 25;

    float nextShotTime;

    public void Shoot()
    {
        if (Time.time > nextShotTime)
        {
            Debug.Log("Shooting");
            nextShotTime = Time.time + msBetweenShots / 1000;          
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
            newProjectile.setSpeed(muzzleVelocity);
        }
    }
}
