///
// Lost In Space
// ICS4U-03
// Kyle Pollock
// Used for features attached to wormhole object: Detecting win and win rewards.
// History:
// 2023-05-17: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPull : MonoBehaviour
{
    private Vector3 lastPosition;
    public static bool pull = true;
    private void Start()
    {
        lastPosition = transform.position;// Store the initial position of the object
    }

    private void Update()
    {
        if (transform.position == lastPosition)// Check if the object has moved since the last frame
        pull = false;
}
}
