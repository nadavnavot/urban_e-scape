using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarController : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject targetObject;

    // Set the specific range of z values for your GameObject
    public float minZ = -5f;
    public float maxZ = 5f;

    void Update()
    {
        if (scrollbar != null && targetObject != null)
        {
            // Clamp the z value to the specified range
            float clampedZ = Mathf.Clamp(targetObject.transform.position.z, minZ, maxZ);

            // Map the clamped z value to a normalized value between 0 and 1
            float normalizedZ = Mathf.InverseLerp(minZ, maxZ, clampedZ);

            // Set the scrollbar value based on the normalized z value
            scrollbar.size = normalizedZ;
        }
    }
}

