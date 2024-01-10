using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public Toggle muteToggle;       // Reference to the Toggle UI component
    public AudioSource audioSource; // Reference to the AudioSource component
    public Sprite unmutedSprite;    // Sprite to display when unmuted
    public Sprite mutedSprite;      // Sprite to display when muted

    void Start()
    {
        // Set the initial state based on the audio source mute status
        UpdateToggleState();

        // Add listener to the toggle's state change event
        muteToggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    void OnToggleValueChanged(bool isMuted)
    {
        // Update the audio source mute status based on the toggle value
        audioSource.mute = isMuted;

        // Update the toggle's sprite based on the mute status
        UpdateToggleSprite(isMuted);
    }

    void UpdateToggleState()
    {
        // Set the toggle's value based on the audio source mute status
        muteToggle.isOn = audioSource.mute;

        // Update the toggle's sprite based on the mute status
        UpdateToggleSprite(audioSource.mute);
    }

    void UpdateToggleSprite(bool isMuted)
    {
        // Change the toggle's sprite based on the mute status
        muteToggle.image.sprite = isMuted ? mutedSprite : unmutedSprite;
    }
}

