using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableDisableWithFade : MonoBehaviour
{
 
    public Button myButton;
    public GameObject[] objectsToDisable;
    public GameObject[] objectsToEnable;
    public float fadeDuration = 0.5f;

    public RawImage[] rawImagesToDisable;
    public RawImage[] rawImagesToEnable;

    void Start()
    {
        // Attach the button click event to the method
        myButton.onClick.AddListener(OnButtonClick);

        // Get RawImage components for arrays
        rawImagesToDisable = new RawImage[objectsToDisable.Length];
        rawImagesToEnable = new RawImage[objectsToEnable.Length];

        for (int i = 0; i < objectsToDisable.Length; i++)
        {
            rawImagesToDisable[i] = objectsToDisable[i].GetComponent<RawImage>();
        }

        for (int i = 0; i < objectsToEnable.Length; i++)
        {
            rawImagesToEnable[i] = objectsToEnable[i].GetComponent<RawImage>();
        }
    }

    void OnButtonClick()
    {
        // Fade out the first set of RawImages
        foreach (RawImage rawImage in rawImagesToDisable)
        {
            if (rawImage != null)
            {
                LeanTween.value(rawImage.gameObject, rawImage.color.a, 0f, fadeDuration)
                    .setOnUpdate((float alpha) =>
                    {
                        Color newColor = rawImage.color;
                        newColor.a = alpha;
                        rawImage.color = newColor;
                    })
                    .setOnComplete(() => rawImage.gameObject.SetActive(false));
            }
        }

        // Fade in the second set of RawImages
        foreach (RawImage rawImage in rawImagesToEnable)
        {
            if (rawImage != null)
            {
                rawImage.gameObject.SetActive(true);
                rawImage.color = new Color(rawImage.color.r, rawImage.color.g, rawImage.color.b, 0f);

                LeanTween.value(rawImage.gameObject, rawImage.color.a, 1f, fadeDuration)
                    .setOnUpdate((float alpha) =>
                    {
                        Color newColor = rawImage.color;
                        newColor.a = alpha;
                        rawImage.color = newColor;
                    });
            }
        }
    }
}


