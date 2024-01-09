using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton_Open : MonoBehaviour
{
    public GameObject Panel; // Reference to the Animator component

    public void SlidePanel()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");

                 animator.SetBool("open", !isOpen);
            }
        }
    }
    
      
    
}

