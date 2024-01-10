using System.Collections;
using System.Collections.Generic;
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
            // Calculate the target Z-position based on scrollbar value
            float targetZ = Mathf.Lerp(7.31f, 3.6f, 41.1f);

            // Update the target object's position
            cameraObject.transform.position = new Vector3(cameraObject.transform.position.x, 
                cameraObject.transform.position.y, 
                targetZ);
        }
        // No need to handle the case when the position is less than 41.1, 
        // as the position will be reset to 41.1 once it exceeds 144
    }
}

