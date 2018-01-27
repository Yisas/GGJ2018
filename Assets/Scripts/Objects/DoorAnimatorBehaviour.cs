using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimatorBehaviour : MonoBehaviour {

    public Animator animator;
    public bool isOpen = false;
    private bool firstAnimation = false;

   protected void FirstAnimationCheck()
    {
        if (!firstAnimation)
        {
            firstAnimation = true;
            animator.SetTrigger("Unlocked");
        }
    }

    public void ToggleOpen()
    {
        FirstAnimationCheck();

        isOpen = !isOpen;
        animator.SetBool("Open", isOpen);
    }

    public void SetOpen()
    {
        FirstAnimationCheck();

        isOpen = true;
        animator.SetBool("Open", isOpen);
    }

    public void SetClosed()
    {
        FirstAnimationCheck();

        isOpen = false;
        animator.SetBool("Open", isOpen);
    }
}
