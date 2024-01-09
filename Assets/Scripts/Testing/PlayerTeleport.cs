using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    // The specific X position to trigger the change
    public float triggerXPosition = -10f;

    // The new position to set when the triggerXPosition is reached
    public Vector3 newPosition = new Vector3(-40f, 2.82f, -7f);

    // Update is called once per frame
    void Update()
    {
        // Check if the GameObject's X position is greater than or equal to the triggerXPosition
        if (transform.position.x >= triggerXPosition)
        {
            // Change the GameObject's position to the new specified position
            transform.position = newPosition;
            Debug.Log("Position changed to " + newPosition + " at X position " + transform.position.x);
        }
    }
}




