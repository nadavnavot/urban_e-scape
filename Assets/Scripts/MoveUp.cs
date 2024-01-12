using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
  
    public float moveSpeed = 2.0f;
        public float scrollSensitivity = 10.0f;
        private bool isMoving = false;

    void Update()
    {
        

       
            // Get the mouse scroll wheel input
            float scrollInput = Input.GetAxis("Mouse ScrollWheel");

            if (scrollInput != 0 && !isMoving)
            {
                // Calculate the new position
                Vector3 newPosition = transform.position + transform.forward * scrollInput * scrollSensitivity;

                // Start the smooth movement
                StartCoroutine(MoveCharacter(newPosition));
            }
    }

        IEnumerator MoveCharacter(Vector3 target)
        {
            isMoving = true;
            float journeyLength = Vector3.Distance(transform.position, target);
            float startTime = Time.time;

            while (Vector3.Distance(transform.position, target) > 0.1f)
            {
                float journey = (Time.time - startTime) * moveSpeed;
                float distanceCovered = journey / journeyLength;
                transform.position = Vector3.Lerp(transform.position, target, distanceCovered);
                yield return null;
            }

            isMoving = false;
        }
        
        
 }





