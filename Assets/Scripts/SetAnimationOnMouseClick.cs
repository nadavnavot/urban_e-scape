using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimationOnMouseClick : MonoBehaviour
{

    void Update()
    {
        // Check if the mouse button is clicked (left mouse button)
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().Play("Rectangle Animation");
        }
    }
}

