using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChangeColorOnCollision : MonoBehaviour
{
    public PostProcessProfile ColorTransition; // Set this in the inspector

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (other.CompareTag("SecondScene")) 
        {
            // Change post-processing profile
            Debug.Log("Changing post-processing profile");
            Camera.main.GetComponent<PostProcessVolume>().profile = ColorTransition;
        }
    }
}