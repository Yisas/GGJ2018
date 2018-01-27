using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushableObject : MonoBehaviour
{
    private float originalMass;
    private bool isBeingPushed = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalMass = rb.mass;
    }

    public void ToggleIsBeingPushed()
    {
        LockUnlockRigidBody(isBeingPushed);
        isBeingPushed = !isBeingPushed;
    }

    public void SetIsBeingPushed(bool beingPushed)
    {
        isBeingPushed = beingPushed;
        LockUnlockRigidBody(!isBeingPushed);
    }

    private void LockUnlockRigidBody(bool locking)
    {
        if (locking)
        {
            //rb.constraints = RigidbodyConstraints.FreezeAll;
            rb.mass = 100;
        }
        else
        {
            //rb.constraints = RigidbodyConstraints.None;
            rb.mass = originalMass;
        }
    }
}
