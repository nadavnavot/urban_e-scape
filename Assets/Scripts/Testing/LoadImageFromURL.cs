using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImageFromURL : MonoBehaviour
{
    public Image imageUI;
    public string imageUrl = "https://example.com/your-image.jpg";

    [System.Obsolete]
    void Start()
    {
        // Call the method to load the image from the specified URL
        LoadImage(imageUrl);
    }

    [System.Obsolete]
    void LoadImage(string url)
    {
        StartCoroutine(LoadImageCoroutine(url));
    }

    [System.Obsolete]
    System.Collections.IEnumerator LoadImageCoroutine(string url)
    {
        // Create a UnityWebRequest to download the image data
        using (WWW www = new WWW(url))
        {
            yield return www;

            if (string.IsNullOrEmpty(www.error))
            {
                // Set the downloaded texture to the Image component
                Texture2D texture = www.texture;
                if (texture != null && imageUI != null)
                {
                    // Set the texture while preserving its aspect ratio
                    imageUI.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                    // Optionally, adjust the Image component's type and preserve aspect setting
                    imageUI.type = Image.Type.Simple;
                    imageUI.preserveAspect = true;
                }
            }
            else
            {
                Debug.LogError("Failed to download image: " + www.error);
            }
        }
    }
}

