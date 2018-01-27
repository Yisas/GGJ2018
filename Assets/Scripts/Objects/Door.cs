using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : DoorAnimatorBehaviour
{

    public int pressurePlateCount;
    private int pressedCount;
    private bool firstAnimation = false;

    private void Start()
    {
        pressedCount = pressurePlateCount;
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
