using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleUIOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float scaleFactor = 1.2f; // Adjust this value to control the scale factor
    public float tweenTime = 0.2f;   // Adjust this value to control the transition time

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Smoothly scale up when the mouse enters
        LeanTween.scale(gameObject, originalScale * scaleFactor, tweenTime)
            .setEase(LeanTweenType.easeOutQuad);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Smoothly reset to the original scale when the mouse exits
        LeanTween.scale(gameObject, originalScale, tweenTime)
            .setEase(LeanTweenType.easeOutQuad);
    }
}


