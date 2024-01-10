using UnityEngine;
using UnityEngine.UI;

public class ScrollbarController : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject targetObject;

    public float minZ = 50f; // Adjust as needed
    public float maxZ = 135f; // Adjust as needed

    public Vector3 resetPosition = new Vector3(0f, 0f, 41.1f); // Set the desired reset position

    void Update()
    {
        float cameraZPosition = targetObject.transform.position.z;

        // Consider using a different condition to trigger the reset
        // For example, a key press or a specific event in your game
        if (cameraZPosition >144)
        {
            targetObject.transform.position = resetPosition;
        }

        // Update the scrollbar size based on the target object's Z-position
        UpdateScrollbar(cameraZPosition);
    }

    void UpdateScrollbar(float zPosition)
    {
        // Clamp the z value to the specified range for the scrollbar
        float clampedZ = Mathf.Clamp(zPosition, minZ, maxZ);

        // Map the clamped z value to a normalized value between 0 and 1
        float normalizedZ = Mathf.InverseLerp(minZ, maxZ, clampedZ);

        // Set the scrollbar value based on the normalized z value
        scrollbar.size = normalizedZ;
    }
}













