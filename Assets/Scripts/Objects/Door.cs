using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : MonoBehaviour {

    public int pressurePlateCount;
    private int pressedCount;
    private bool firstAnimation = false;

    public bool isOpen = false;

    public Animator animator;

    private void Start()
    {
        pressedCount = pressurePlateCount;
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

    private void FirstAnimationCheck()
    {
        if (!firstAnimation)
        {
            firstAnimation = true;
            animator.SetTrigger("Unlocked");
        }
    }

    public void DecCount()
    {
        pressedCount -= 1;

        if (pressedCount < 0)
            pressedCount = 0;

        if (pressedCount == 0)
            SetOpen();
    }

    public void IncCount()
    {
        if (pressedCount == 0)
            SetClosed();

        pressedCount += 1;

        if(pressedCount >=  pressurePlateCount)
        {
            pressedCount = pressurePlateCount;
        }
    }
}
