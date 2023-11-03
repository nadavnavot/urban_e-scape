using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;

    private Camera currentCamera;
    private int currentCameraIndex = 0;

    private void Start()
    {
        if (cameras.Length > 0)
        {
            currentCamera = cameras[currentCameraIndex];
            currentCamera.enabled = true;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SwitchCamera();
        }
    }

    private void SwitchCamera()
    {
        if (cameras.Length == 0)
            return;

        currentCamera.enabled = false;
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
        currentCamera = cameras[currentCameraIndex];
        currentCamera.enabled = true;
    }
}


