using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChangeColorWarehouse : MonoBehaviour
{
    public GameObject cameraObject;
    public PostProcessProfile ColorTransition1; // Set this in the inspector
    

    void Update()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, 
            cameraObject.transform.position);
        Debug.Log(distanceFromPlayer);
        if (distanceFromPlayer <= 39f)
        {
            // Change post-processing profile
            Debug.Log("Changing post-processing profile");
            cameraObject.GetComponent<PostProcessVolume>().profile = ColorTransition1;
        }
    }
}