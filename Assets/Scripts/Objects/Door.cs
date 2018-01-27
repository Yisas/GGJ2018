using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : MonoBehaviour {

    public Animator animator;

    public void ToggleOpen()
    {
        animator.SetTrigger("ToggleOpen");
    }
}
