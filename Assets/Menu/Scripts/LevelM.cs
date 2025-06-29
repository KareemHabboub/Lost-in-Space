///
// Lost In Space
// ICS4U-03
// Kareem Habboub
// This program changes scenes with slight delay
// History:
// 2023-04-2: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelM : MonoBehaviour
{
    public string sceneName;
    public void changeScene()
    {        
        /*
        Changes the scene to the specified sceneName after a short delay.
        */
        // Reverting time scale back to normal incase user clicks button after victory screen
        if (sceneName != "Level2" && sceneName != "Level3")
        {
        Time.timeScale = 1; 
        ReadyButton.ready = false;
        StartCoroutine(DelayedSceneLoad());
        }
        if(sceneName == "Level2")
        {
            if(level2.unlock == true)
            {
            Time.timeScale = 1; 
            ReadyButton.ready = false;
            StartCoroutine(DelayedSceneLoad());
            }
        }
        if(sceneName == "Level3")
        {
            if(level3.unlock == true)
            {
            Time.timeScale = 1; 
            ReadyButton.ready = false;
            StartCoroutine(DelayedSceneLoad());
            }
        }
             
    }

    private IEnumerator DelayedSceneLoad()
    {
        yield return new WaitForSeconds(0.1f); // Delay of 0.1 seconds so the SFX can play
        SceneManager.LoadScene(sceneName);
    }
}
