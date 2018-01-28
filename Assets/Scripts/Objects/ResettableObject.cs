using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ResettableObject : MonoBehaviour {

    private Vector3 ogPosition;
    private Quaternion ogRotation;

	// Use this for initialization
	void Start () {
        ogPosition = transform.position;
        ogRotation = transform.rotation;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Deadzone"))
            Reset();
    }

    public void Reset()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

        transform.position = ogPosition;
        transform.rotation = ogRotation;
    }

    public Vector3 RespawnPosition
    {
        get { return ogPosition; }
        set { ogPosition = value; }
    }

    public Quaternion RespawnRotation
    {
        get { return ogRotation; }
        set { ogRotation = value; }
    }
}
