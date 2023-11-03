using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    public Transform character;         // The character's Transform
    public Transform textPosition;       // The specific position where you want the text to appear
    public TextMeshProUGUI textToShow;   // The TextMeshPro text to display
    public float activationDistance = 2.0f;  // The distance at which the text will appear

    private bool isTextVisible = false;

    void Update()
    {
        // Calculate the distance between the character and the specific position
        float distance = Vector3.Distance(character.position, textPosition.position);

        // Check if the character is within the activation distance
        if (distance <= activationDistance && !isTextVisible)
        {
            // Show the TextMeshPro text
            textToShow.gameObject.SetActive(true);
            isTextVisible = true;
        }
        else if (distance > activationDistance && isTextVisible)
        {
            // Hide the TextMeshPro text
            textToShow.gameObject.SetActive(false);
            isTextVisible = false;
        }
    }
}


