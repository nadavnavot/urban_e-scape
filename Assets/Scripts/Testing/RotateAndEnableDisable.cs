using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndEnableDisable : MonoBehaviour
{
    public GameObject[] elementsToToggle; // Array of GameObjects to enable/disable
    public float rotationSpeed = 45.0f;    // Rotation speed in degrees per second
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            // Calculate the rotation angle based on the rotation speed and time
            float rotationAngle = rotationSpeed * Time.deltaTime;

            // Rotate the cube around the Y-axis
            transform.Rotate(Vector3.up, rotationAngle);

            // Check if the rotation angle has reached 180 degrees
            if (Mathf.Abs(transform.rotation.eulerAngles.y) >= 180.0f)
            {
                isRotating = false;

                // Apply changes when the cube reaches 180 degrees Y rotation
                ApplyChanges();
            }
        }
    }

    void OnMouseDown()
    {
        // Start rotating the cube when clicked
        isRotating = true;
    }

    void ApplyChanges()
    {
        // Enable or disable elements in the array
        foreach (GameObject element in elementsToToggle)
        {
            if (element != null)
            {
                element.SetActive(!element.activeSelf);
            }
        }
    }
}

