using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderCustomScene : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public int targetSceneIndex;

    private void OnMouseDown()
    {
        LoadNextScene();
    }
    

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(targetSceneIndex));

    }

    IEnumerator LoadScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}

