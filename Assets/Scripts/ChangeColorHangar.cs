using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChangeColorHangar : MonoBehaviour
{
    public GameObject cameraObject;
    public PostProcessProfile ColorTransition2; // Set this in the inspector
    

    void Update()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, 
            cameraObject.transform.position);
        Debug.Log(distanceFromPlayer);
        if (distanceFromPlayer <= 40f)
        {
            // Change post-processing profile
            Debug.Log("Changing post-processing profile");
            cameraObject.GetComponent<PostProcessVolume>().profile = ColorTransition2;
        }
    }
}