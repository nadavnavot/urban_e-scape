using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnClick : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // Adjustable rotation speed in degrees per second
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            // Calculate the rotation angle based on the rotation speed and time
            float rotationAngle = rotationSpeed * Time.deltaTime;

            // Rotate the rectangle around the Y-axis
            transform.Rotate(Vector3.up, rotationAngle);

            // Check if the rotation angle has reached 180 degrees
            if (Mathf.Abs(transform.rotation.eulerAngles.y) <= 180.0f)
            {
                isRotating = false;
            }
        }
    }

    void OnMouseDown()
    {
        // Start the rotation when the rectangle is clicked
        isRotating = true;
    }
}


