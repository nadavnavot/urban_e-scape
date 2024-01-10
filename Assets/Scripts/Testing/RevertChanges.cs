using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevertChanges : MonoBehaviour
{
    public GameObject[] elementsToToggle; // Array of GameObjects to enable/disable
    public GameObject cube; // Reference to the cube GameObject
    public float rotationSpeed = 45.0f; // Rotation speed in degrees per second

    public void Revert()
    {
        Debug.Log("Revert method called");

        // Revert changes: Enable or disable elements in the array
        foreach (GameObject element in elementsToToggle)
        {
            if (element != null)
            {
                element.SetActive(!element.activeSelf);
            }
        }

        // Rotate the cube back to 0
        RotateCubeToZero();
    }

    public void RotateCubeToZero()
    {
        if (cube != null)
        {
            // Calculate the rotation angle based on the rotation speed and time
            float rotationAngle = rotationSpeed * Time.deltaTime;

            // Rotate the cube around the Y-axis
            cube.transform.Rotate(Vector3.up, -rotationAngle); // Use -rotationAngle to rotate back to 0

            // Check if the rotation angle has reached approximately 0 degrees
            if (Mathf.Abs(cube.transform.rotation.eulerAngles.y) <= 180.0f)
            {
                // Ensure the cube is exactly at 0 degrees
                cube.transform.rotation = Quaternion.identity;
            }
        }
    }
}

