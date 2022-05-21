using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Fire(Transform firePoint) => Instantiate(Bullet, firePoint.position, Quaternion.identity, firePoint);
}
