using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChangeColorHall : MonoBehaviour
{
    public GameObject cameraObject;
    public PostProcessProfile ColorTransitionOn; // Set this in the inspector
    public PostProcessProfile ColorTransitionOff; // Set this in the inspector
    public Color cameraBackgroundColor = new Color(0.866f, 0.514f, 0.204f); // #DD8334
    public Color fogColor = new Color(0.914f, 0.604f, 0.333f); // #E99A55
    public Material customSkybox; // Assign your custom skybox material here

    private Camera cam; // Reference to the Camera component
    private Material originalSkybox; // To store the original skybox material

    void Start()
    {
        originalSkybox = RenderSettings.skybox;
    }

    void Update()
    {
        float cameraZPosition = cameraObject.transform.position.z;
        Debug.Log("Camera Z-Position: " + cameraZPosition);

        // Check if the Z-position is within the specified range (74 to 107)
        if (cameraZPosition >= 74f && cameraZPosition <= 107f)
        {
            // Change post-processing profile
            Debug.Log("Changing post-processing profile");
            cameraObject.GetComponent<PostProcessVolume>().profile = ColorTransitionOn;

            // Get the Camera component from the cameraObject
            cam = cameraObject.GetComponent<Camera>();
            // Change the camera's background color
            cam.backgroundColor = cameraBackgroundColor;

            // Change the fog color
            RenderSettings.fogColor = fogColor;
            RenderSettings.skybox = customSkybox; // Change the skybox to the custom one
        }
        else
        {
            cameraObject.GetComponent<PostProcessVolume>().profile = ColorTransitionOff;
            RenderSettings.skybox = originalSkybox; // Reset the skybox to the original one
        }
        
    }
}