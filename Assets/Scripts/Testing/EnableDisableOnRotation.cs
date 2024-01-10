using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableDisableOnRotation : MonoBehaviour
{
    public GameObject targetObject;  // The GameObject to check rotation
    public GameObject uiPanelToShow; // The UI panel to show
    public GameObject[] elementsToDisable; // Array of UI elements and GameObjects to disable
    public float rotationThreshold = 178f; // Rotation threshold to trigger the action

    void Update()
    {
        if (targetObject != null && uiPanelToShow != null)
        {
            // Check the Y rotation of the targetObject
            float yRotation = targetObject.transform.rotation.eulerAngles.y;

            // If Y rotation is less than the threshold, enable the UI panel and disable elements
            if (yRotation > rotationThreshold)
            {
                EnablePanelAndDisableElements();
            }
        }
    }

    void EnablePanelAndDisableElements()
    {
        // Enable the UI panel
        if (uiPanelToShow != null)
        {
            uiPanelToShow.SetActive(true);
        }

        // Disable UI elements and GameObjects in the array
        foreach (GameObject element in elementsToDisable)
        {
            if (element != null)
            {
                element.SetActive(false);
            }
        }
    }
}
