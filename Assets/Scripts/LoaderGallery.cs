using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderGallery : MonoBehaviour
{
   public Animator transition;
   public float transitionTime = 1f;

   private void Update()
   {
       if (Input.GetMouseButtonDown(0))
       {
           LoadNextScene();
       }
   }

   public void LoadNextScene()
   {
       StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
   }

   IEnumerator LoadScene(int sceneIndex)
   {
       transition.SetTrigger("Start");
       yield return new WaitForSeconds(transitionTime);
       SceneManager.LoadScene(sceneIndex);
   }
}
