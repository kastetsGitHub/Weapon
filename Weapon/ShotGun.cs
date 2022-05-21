using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    public override void Fire(Transform firePoint) 
    {
        if (Bullet is ShotGunBullet)
        {
            Instantiate(Bullet, firePoint.position, Quaternion.identity, firePoint);
        }
    } 

}
