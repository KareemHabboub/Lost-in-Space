///
// Lost In Space
// ICS4U-03
// Kareem Habboub
// This script quits the game
// History:
// 2023-02-10: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*
    Quits the game when called.
    */
    public void QuitGame()
    {
        Application.Quit();
    }
}

