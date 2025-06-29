///
// Lost In Space
// ICS4U-03
// Kyle Pollock
// This program unlocks the next level
// History:
// 2023-06-08: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3 : MonoBehaviour
{
    public static bool unlock = false;
    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {
            unlock = true;
        }
    }
}
