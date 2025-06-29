///
// Lost In Space
// ICS4U-03
// Kareem Habboub
// This script uses the DontDestroyOnLoad method to prevent the background music (BGM) from being deleted across scenes.
// History:
// 2023-04-2: Program Creation
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DND : MonoBehaviour
{
    private void Awake()
    {
        /*
        Finds all game objects with the "BGM" tag and checks if there are more than one.
        If multiple objects with the "BGM" tag are found, destroys this game object to ensure only one BGM persists.
        */
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BGM");
        if( musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        // Keeps this game object and its attached BGM from being destroyed when loading new scenes.
        DontDestroyOnLoad(this.gameObject);
    }
}
