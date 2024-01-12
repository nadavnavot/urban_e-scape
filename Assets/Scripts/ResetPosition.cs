using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public GameObject cameraObject;

    // Variables for looping
    public float loopStartZ = 41.1f;
    public float loopEndZ = 144f;

    void Update()
    {
        float cameraZPosition = cameraObject.transform.position.z;

        // Check if the Z-position has exceeded the loop end value
        if (cameraZPosition > loopEndZ)
        {
            // Reset the Z-position to loopStartZ
            cameraObject.transform.position = new Vector3(cameraObject.transform.position.x, 
                cameraObject.transform.position.y, 
                loopStartZ);
        }
    }
}


