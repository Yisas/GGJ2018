using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public static UIManager Instance;
    public GameObject dialog;
    public Text textBox;

	// Use this for initialization
	void Start () {
        Instance = this;
	}

    public void showText(string text)
    {
        textBox.text = text;
        dialog.SetActive(true);
    }

    public void hideText()
    {
        dialog.SetActive(false);
    }
}
