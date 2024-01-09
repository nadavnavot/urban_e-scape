using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableDisableScript : MonoBehaviour
{
    public Button myButton;
    public GameObject objectToDisable;
    public GameObject objectToEnable;

    void Start()
    {
        // Attach the button click event to the method
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Disable the first GameObject
        if (objectToDisable != null)
        {
            objectToDisable.SetActive(false);
        }

        // Enable the second GameObject
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true);
        }
    }
}

