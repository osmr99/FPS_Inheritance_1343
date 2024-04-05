using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Gun
{
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);
        b.GetComponent<Projectile>().Initialize(25, 5, 0.05f, 50, null); // version without special effect


        anim.SetTrigger("shoot");
        elapsed = 0;
        //ammo -= 1;

        Debug.Log("Swing");

        return true;
    }
}
