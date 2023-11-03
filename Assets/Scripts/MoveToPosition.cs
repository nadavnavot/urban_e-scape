using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public Vector3 targetPosition;  // The desired position to move to
    public float speed = 1.0f;      // The movement speed

    private bool isMoving = false;  // Flag to track if the object is currently moving

    void Update()
    {
        // Check if the object is not currently moving and the target position is different from the current position
        if (Input.GetMouseButtonDown(0) && !isMoving && transform.position != targetPosition)
        {
            // Start the movement
            StartCoroutine(MoveObject());
        }
    }

    IEnumerator MoveObject()
    {
        isMoving = true;

        Vector3 initialPosition = transform.position;
        float journeyLength = Vector3.Distance(initialPosition, targetPosition);
        float startTime = Time.time;

        while (transform.position != targetPosition)
        {
            float distanceCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distanceCovered / journeyLength;

            transform.position = Vector3.Lerp(initialPosition, targetPosition, fractionOfJourney);

            yield return null;
        }

        isMoving = false;
    }
}

