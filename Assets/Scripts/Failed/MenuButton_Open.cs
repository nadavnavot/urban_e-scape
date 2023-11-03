using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton_Open : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public string boolParameterName = "Open"; // The name of the boolean parameter in the Animator

    private bool isOpen = false; // Track the current state

    void Start()
    {
        // Initialize the Animator parameter
        animator.SetBool(boolParameterName, isOpen);
    }

    public void ToggleParameter()
    {
        // Toggle the Animator parameter when the button is clicked
        isOpen = !isOpen;
        animator.SetBool(boolParameterName, isOpen);
    }
}

