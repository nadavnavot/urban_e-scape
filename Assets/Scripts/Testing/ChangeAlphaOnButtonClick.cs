using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeAlphaOnButtonClick : MonoBehaviour
{
    public Button myButton;
    public Image[] imagesToFade;
    public RawImage[] rawImagesToFade;
    public TextMeshProUGUI[] textMeshesToFade;
    public float fadeDuration = 0.5f;

    void Start()
    {
        // Attach the button click event to the method
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Fade out Images
        foreach (Image image in imagesToFade)
        {
            if (image != null)
            {
                LeanTween.alpha(image.rectTransform, 0f, fadeDuration)
                    .setOnComplete(() => image.gameObject.SetActive(false));
            }
        }

        // Fade out RawImages
        foreach (RawImage rawImage in rawImagesToFade)
        {
            if (rawImage != null)
            {
                LeanTween.alpha(rawImage.rectTransform, 0f, fadeDuration)
                    .setOnComplete(() => rawImage.gameObject.SetActive(false));
            }
        }

        // Fade out TextMeshProUGUI
        foreach (TextMeshProUGUI textMesh in textMeshesToFade)
        {
            if (textMesh != null)
            {
                LeanTween.alpha(textMesh.rectTransform, 0f, fadeDuration)
                    .setOnComplete(() => textMesh.gameObject.SetActive(false));
            }
        }
    }

}

