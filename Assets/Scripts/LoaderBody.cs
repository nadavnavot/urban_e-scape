using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderBody : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object or its position is the desired one
                if (hit.collider.gameObject.CompareTag("HitMe"))
                {
                    LoadNextScene();
                }
            }
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

