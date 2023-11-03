using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_02 : MonoBehaviour
{
    private bool isMouseOver = false;
    private Vector3 originalScale;
    private Vector3 targetScale;
    public float scaleSpeed = 2.0f;

    private void Start()
    {
        originalScale = transform.localScale;
        targetScale = originalScale * 1.2f;
    }

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
            // Scale the GameObject towards the target scale
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
        }
        else
        {
            // Return the GameObject to its original scale
            transform.localScale = Vector3.Lerp(transform.localScale, originalScale, scaleSpeed * Time.deltaTime);
        }
    }
}


