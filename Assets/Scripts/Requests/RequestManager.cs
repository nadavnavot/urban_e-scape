using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI; // Required for the Image component


[Serializable]
public class ArtworkDetailResponse
{
    public Artwork artwork;
    public Media[] media; // Assuming there can be multiple media entries for one artwork
    public Artist artist;
}

public class RequestManager : MonoBehaviour
{
    private string _apiBaseURL = "http://localhost:7120/swagger/index.html"; // Adjust this to your API's base URL

    // UI Text elements to display artwork details
    public TMP_Text artworkDescriptionText;
    public TMP_Text artworkTitleText;
    public TMP_Text artCategoryText;
    public TMP_Text locationText;
    public TMP_Text yearOfCreationText;
    public TMP_Text statusText;
    public TMP_Text artistNameText;
    public Image artworkImage; // Reference to the UI Image component for the artwork

    // Start is called before the first frame update
    void Start()
    {
        GetArtwork("1"); // Call this with the appropriate artwork ID
    }

    // Method to start the coroutine to get artwork details
    public void GetArtwork(string artworkId)
    {
        StartCoroutine(GetArtworkCoroutine(artworkId));
    }

    // Coroutine to get artwork details from the server
    IEnumerator GetArtworkCoroutine(string artworkId)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(_apiBaseURL + "Art/GetArtworkWithMedia/" + artworkId))
        {
            // Request and wait for the desired page
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Received: " + webRequest.downloadHandler.text);
                ArtworkDetailResponse response = JsonUtility.FromJson<ArtworkDetailResponse>(webRequest.downloadHandler.text);

                // Update UI with artwork details
                UpdateArtworkDetails(response.artwork);
                UpdateArtistDetails(response.artist);


                // Assuming the first media is the image you want to display
                if (response.media != null && response.media.Length > 0)
                {
                    // Start a coroutine to load the image from the URL
                    StartCoroutine(LoadImage(response.media[0].media));
                }
            }
            else
            {
                Debug.LogError("Error: " + webRequest.error);
            }
        }
    }

    // Update the UI with artwork details
    private void UpdateArtworkDetails(Artwork artwork)
    {
        artworkDescriptionText.text = artwork.artwork_name;
        artworkTitleText.text = artwork.description; // Use this field as per your UI design
        artCategoryText.text = artwork.art_category;
        locationText.text = artwork.location;
        yearOfCreationText.text = artwork.year_of_creation.ToString();
        statusText.text = artwork.status ? "Exist" : "Not Exist";
    }
    private void UpdateArtistDetails(Artist artist)
    {
        artistNameText.text = artist.name;
    }

    // Coroutine to load image from URL
    IEnumerator LoadImage(string imageUrl)
    {
        UnityWebRequest imageRequest = UnityWebRequestTexture.GetTexture(imageUrl);

        yield return imageRequest.SendWebRequest();

        if (imageRequest.result == UnityWebRequest.Result.Success)
        {
            Texture2D texture = DownloadHandlerTexture.GetContent(imageRequest);
            artworkImage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }
        else
        {
            Debug.LogError("Error loading image: " + imageRequest.error);
        }
    }
}

