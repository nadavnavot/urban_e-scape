using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAlphaOnRotation : MonoBehaviour
{
    public GameObject targetObject; // The GameObject to check rotation
    public GameObject panelToShow;  // The UI panel to show
    public float rotationThreshold = -170f; // Rotation threshold to trigger the panel activation

    void Update()
    {
        if (targetObject != null && panelToShow != null)
        {
            // Check the Y rotation of the targetObject
            float yRotation = targetObject.transform.rotation.eulerAngles.y;

            // If Y rotation is less than the threshold, set the UI panel to active
            if (yRotation < rotationThreshold)
            {
                panelToShow.SetActive(true);
            }
        }
    }
}


