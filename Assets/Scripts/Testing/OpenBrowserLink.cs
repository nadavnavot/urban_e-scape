using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBrowserLink : MonoBehaviour
{
    public Button myButton;
    public string linkToOpen = "https://www.example.com";

    void Start()
    {
        // Attach the button click event to the method
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Open the default web browser with the specified link
        Application.OpenURL(linkToOpen);
    }
}

