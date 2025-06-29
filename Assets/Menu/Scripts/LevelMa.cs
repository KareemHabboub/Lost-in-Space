///
// Lost In Space
// ICS4U-03
// Kareem Habboub
// This program changes scenes without delay
// History:
// 2023-05-29: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMa : MonoBehaviour
{
    public string sceneName;

    public void changeScene()
    {
        /*
        Changes the scene to the specified sceneName
        */

        SceneManager.LoadScene(sceneName);

    }

}