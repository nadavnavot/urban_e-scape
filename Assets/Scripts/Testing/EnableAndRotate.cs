using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndRotate : MonoBehaviour
{
    public GameObject targetObject;
    public float rotationSpeed = 45.0f; // Adjustable rotation speed in degrees per second
    private bool isRotating = false;
    private bool isEnabled = false;

    void Update()
    {
        if (isRotating)
        {
            // Calculate the rotation angle based on the rotation speed and time
            float rotationAngle = rotationSpeed * Time.deltaTime;

            // Rotate the target object around the Y-axis
            targetObject.transform.Rotate(Vector3.up, rotationAngle);

            // Check if the rotation angle has reached 180 degrees
            if (Mathf.Abs(targetObject.transform.rotation.eulerAngles.y) <= 180.0f)
            {
                isRotating = false;
            }
        }
    }

    void OnMouseDown()
    {
        if (!isEnabled)
        {
            // Enable the target GameObject before starting the rotation
            targetObject.SetActive(true);
            isEnabled = true;
        }

        // Start the rotation when the GameObject is clicked
        isRotating = true;
    }
}


