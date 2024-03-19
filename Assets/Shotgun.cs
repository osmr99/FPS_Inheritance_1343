using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Gun
{
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        return true;
    }
}
