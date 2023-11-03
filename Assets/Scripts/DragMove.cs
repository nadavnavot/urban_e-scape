using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Adjustable speed
    private bool isDragging = false;
    private Vector3 lastMousePosition;

    void Update()
    {
        if (isDragging)
        {
            // Calculate the mouse movement since the last frame
            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;

            // Convert the screen position to world position
            Vector3 moveDirection = Camera.main.transform.TransformDirection(Vector3.forward);
            moveDirection.x = 0;  // Ensure movement only happens along the Z-axis

            // Apply the movement to the GameObject
            transform.position += moveDirection * moveSpeed * deltaMousePosition.y * Time.deltaTime;
        }

        // Update the last mouse position
        lastMousePosition = Input.mousePosition;

        // Check for mouse button press to start dragging
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }

        // Check for mouse button release to stop dragging
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }
}

