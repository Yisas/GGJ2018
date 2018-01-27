﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Test"))
        {
            ResetAllResetableObjects();
        }
    }

    public void ResetAllResetableObjects()
    {
        foreach (ResettableObject ro in GameObject.FindObjectsOfType<ResettableObject>())
            ro.Reset();
    }
}
