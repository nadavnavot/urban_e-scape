using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private Vector3 targetPosition;
    private bool isDragging = false;

    void Update()
    {
        if (isDragging)
        {
            // Calculate the movement direction based on mouse position
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Vector3.Distance(transform.position, Camera.main.transform.position);
            targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Ensure the character stays at the same Y level
            targetPosition.x = transform.position.x;

            // Move the character towards the target position
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }

    void OnMouseDrag()
    {
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}




