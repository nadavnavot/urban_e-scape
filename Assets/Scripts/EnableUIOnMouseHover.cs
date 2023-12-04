using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnableUIOnMouseHover : MonoBehaviour
{
    public GameObject targetObject; // The GameObject to hover over
    public GameObject uiElementToEnable; // The UI element to enable

    private bool isMouseOver = false;

    void Start()
    {
        if (targetObject == null || uiElementToEnable == null)
        {
            Debug.LogError("Target Object or UI Element is not assigned!");
        }
        else
        {
            // Disable the UI element initially
            uiElementToEnable.SetActive(false);
        }
    }

    void Update()
    {
        if (isMouseOver)
        {
            // Enable the UI element when the mouse is over the target object
            uiElementToEnable.SetActive(true);
    
            // Check if the left mouse button is clicked
            if (Input.GetMouseButtonDown(0))
            {
                // Call the ReloadLevel method with the desired scene index (1 for scene 1)
                ReloadLevel(1);
            }
        }
        else
        {
            // Disable the UI element when the mouse is not over the target object
            uiElementToEnable.SetActive(false);
        }
    }
    
    void ReloadLevel(int sceneIndex)

    {
        SceneManager.LoadScene(sceneIndex);
    }

    void OnMouseEnter()
    {
        if (gameObject == targetObject)
        {
            isMouseOver = true;
        }
    }

    void OnMouseExit()
    {
        isMouseOver = false;
    }
}


