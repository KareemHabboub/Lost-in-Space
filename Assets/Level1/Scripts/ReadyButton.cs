///
// Lost In Space
// ICS4U-03
// Kyle Pollock
// Detects when button object is pressed
// History:
// 2023-05-16: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyButton : MonoBehaviour
{
    public static bool ready = false;
    public void start(){ // called when button is pressed |not a Start() function|
        ready = true; // set ready to true
    }
}
