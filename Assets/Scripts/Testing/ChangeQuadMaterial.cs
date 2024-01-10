using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ChangeQuadMaterial : MonoBehaviour
{
    public Renderer quadRenderer; // Reference to the quad's renderer
    public string imageUrl = "https://example.com/image.jpg"; // Replace with your image URL

    void Start()
    {
        // Start the coroutine to load the image from the URL
        StartCoroutine(LoadImage());
    }

    IEnumerator LoadImage()
    {
        // Send a UnityWebRequest to download the image
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(imageUrl);
        yield return www.SendWebRequest();

        // Check for errors during the download
        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Error downloading image: " + www.error);
        }
        else
        {
            // Get the downloaded texture
            Texture2D texture = DownloadHandlerTexture.GetContent(www);

            // Apply the texture to the quad's material
            if (quadRenderer != null && texture != null)
            {
                quadRenderer.material.mainTexture = texture;
            }
        }
    }
}

