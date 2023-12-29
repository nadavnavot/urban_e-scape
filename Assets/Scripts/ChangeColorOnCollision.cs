using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChangeColorOnCollision : MonoBehaviour
{
    public PostProcessProfile ColorTransition; // Set this in the inspector
    Camera mainCamera = Camera.main;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (gameObject.CompareTag("SecondScene")) 
        {
            // Change post-processing profile
            Debug.Log("Changing post-processing profile");
            mainCamera.GetComponent<PostProcessVolume>().profile = ColorTransition;
        }
    }
}