///
// Lost In Space
// ICS4U-03
// Kareem Habboub
// This program allows the user to press enter in order to proceed onto the level select scene
// History:
// 2023-03-05: Program Creation
///

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputSystem : MonoBehaviour
{
    void Update()
    {
        /*
        Checks if the Enter key (Return key) is pressed.
        If so, loads the "LevelSelect" scene.
        */
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
