using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string targetSceneName = "YourTargetSceneName"; // Replace with the name of your target scene

    void Update()
    {
        // Example: Change scene when the "Space" key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        // Load the target scene
        SceneManager.LoadScene(targetSceneName);
    }
}

