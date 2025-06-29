///
// Lost In Space
// ICS4U-03
// Kyle Pollock
// Mirros object positions
// History:
// 2023-05-15: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
public Transform originalObject; // reference to the original object
public Transform mirroredObject; // reference to the object to mirror

void Update()
{
    Vector2 originalPos = originalObject.position; // get the original position of the object
    Vector2 mirroredPos = new Vector2(originalPos.x, originalPos.y); // create a new vector with mirrored x and y values
    mirroredObject.position = mirroredPos; // assign the mirrored position to the mirrored object
}
}
        
        