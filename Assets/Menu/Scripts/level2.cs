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
using UnityEngine.SceneManagement;

public class level2 : MonoBehaviour
{
    public static bool unlock = false;

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {
            Scene scene = SceneManager.GetActiveScene();
            string currentLevel = scene.name.ToString();
            Debug.Log(currentLevel);
            
        if(currentLevel == scene.name)
            {
            unlock = true;
            }
        }
    }
}
