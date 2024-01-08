using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderGallery : MonoBehaviour
{
    private bool isMouseOver = false;
    public Animator transition;
    public float transitionTime = 1f;

   private void OnMouseEnter()
   {
       isMouseOver = true;
   }

   private void OnMouseExit()
   {
       isMouseOver = false;
   }
   
   private void Update()
   {
       if (isMouseOver)
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
