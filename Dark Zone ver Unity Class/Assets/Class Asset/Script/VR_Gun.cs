using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VR_Gun : VRTK_InteractableObject
{

    public GameObject gun;
    private Class_GunShoot gunScript;

    private void Start()
    {
        gunScript = gun.GetComponent<Class_GunShoot>();
    }

    public override void StartUsing(VRTK_InteractUse currentUsingObject)
    {
        base.StartUsing(currentUsingObject);
        gunScript.Fire();
    }
}
