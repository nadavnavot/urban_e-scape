using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnMouseHover_01 : MonoBehaviour
{
    private bool isMouseOver = false;
    private Quaternion originalRotation;
    public float rotationSpeed = 30.0f;

    private void Start()
    {
        originalRotation = transform.rotation;
    }

    private void OnMouseEnter()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    private void Update()
    {
        if (isMouseOver)
        {
            // Rotate the GameObject to the right by 30 degrees per second
            transform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        }
        else
        {
            // Return the GameObject to its original rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, originalRotation, Time.deltaTime);
        }
    }
}


