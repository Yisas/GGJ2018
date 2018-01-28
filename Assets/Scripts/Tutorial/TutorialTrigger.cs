﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TutorialTrigger : MonoBehaviour {
    [TextArea(3, 10)]
    public string myText = "This text will appear in a text area";

    void OnTriggerEnter(Collider other)
    {
        UIManager.Instance.showText(myText);
    }

    void OnTriggerExit(Collider other)
    {
        UIManager.Instance.hideText();
    }
}
