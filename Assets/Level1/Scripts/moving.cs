///
// Lost In Space
// ICS4U-03
// Kyle Pollock
// Detecting motion from object
// History:
// 2023-05-16: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    private Vector3 lastPosition;
    public static bool grav = false;
    private void Start()
    {
        // Store the initial position of the object
        lastPosition = transform.position;
    }

    private void Update()
    {
        // Check if the object has moved since the last frame
        if (transform.position != lastPosition)
        {
            grav = true;    
        }
    }
}
