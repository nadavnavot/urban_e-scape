using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChangeColorHangar : MonoBehaviour
{
    public GameObject cameraObject;
    public PostProcessProfile ColorTransitionOn; // Set this in the inspector
    public PostProcessProfile ColorTransitionOff; // Set this in the inspector
    public Color cameraBackgroundColor = new Color(0.698f, 0.141f, 0.949f); // #B224F2
    public Color fogColor = new Color(0.541f, 0.106f, 0.737f); // #8A1CBC
    public Material customSkybox; // Assign your custom skybox material here

    private Camera cam; // Reference to the Camera component
    private Color originalCameraBackgroundColor; // To store the original camera background color
    private Color originalFogColor; // To store the original fog color
    private Material originalSkybox; // To store the original skybox material

    void Start()
    {
        // Get the Camera component from the cameraObject
        cam = cameraObject.GetComponent<Camera>();

        // Store the original colors
        originalCameraBackgroundColor = cam.backgroundColor;
        originalFogColor = RenderSettings.fogColor;
        originalSkybox = RenderSettings.skybox;
        
    }

    void Update()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, cameraObject.transform.position);
        Debug.Log(distanceFromPlayer);

        if (distanceFromPlayer <= 40f)
        {
            // Change post-processing profile
            Debug.Log("Changing post-processing profile to On");
            cameraObject.GetComponent<PostProcessVolume>().profile = ColorTransitionOn;

            // Change the camera's background color
            cam.backgroundColor = cameraBackgroundColor;

            // Change the fog color
            RenderSettings.fogColor = fogColor;
            RenderSettings.skybox = customSkybox; // Change the skybox to the custom one
        }
        else
        {
            // Reset to original settings when the distance is greater than 40 units
            Debug.Log("Resetting to original settings");
            cameraObject.GetComponent<PostProcessVolume>().profile = ColorTransitionOff;
            cam.backgroundColor = originalCameraBackgroundColor;
            RenderSettings.fogColor = originalFogColor;
        }
    }
}
